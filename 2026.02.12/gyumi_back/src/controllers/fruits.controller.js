const repo = require("../repositories/fruits.repo");

function parseId(req, res) {
  const id = Number(req.params.id);
  if (!Number.isInteger(id) || id <= 0) {
    res.status(400).json({ error: "Hibás id." });
    return null;
  }
  return id;
}

function validateCreate(body) {
  if (!body || typeof body !== "object") return "Body hiányzik.";
  if (!body.nev || typeof body.nev !== "string") return "A 'nev' kötelező (string).";
  if (!body.alt_szoveg || typeof body.alt_szoveg !== "string") return "Az 'alt_szoveg' kötelező (string).";
  if (!body.src || typeof body.src !== "string") return "A 'src' kötelező (string).";
  if (body.megjegyzes != null && typeof body.megjegyzes !== "string") return "A 'megjegyzes' csak string lehet.";
  if (body.nev_eng != null && typeof body.nev_eng !== "string") return "A 'nev_eng' csak string lehet.";
  return null;
}

async function getAll(req, res, next) {
  try {
    res.json(await repo.findAll());
  } catch (e) {
    next(e);
  }
}

async function getById(req, res, next) {
  try {
    const id = parseId(req, res);
    if (!id) return;

    const fruit = await repo.findById(id);
    if (!fruit) return res.status(404).json({ error: "Nincs ilyen gyümölcs." });

    res.json(fruit);
  } catch (e) {
    next(e);
  }
}

async function create(req, res, next) {
  try {
    const msg = validateCreate(req.body);
    if (msg) return res.status(400).json({ error: msg });

    const created = await repo.insertOne(req.body);
    res.status(201).json(created);
  } catch (e) {
    if (e && e.code === "ER_DUP_ENTRY") {
      return res.status(409).json({ error: "Ilyen 'nev' már létezik (UNIQUE)." });
    }
    next(e);
  }
}

async function update(req, res, next) {
  try {
    const id = parseId(req, res);
    if (!id) return;

    const patch = req.body || {};
    const allowed = ["nev", "megjegyzes", "nev_eng", "alt_szoveg", "src"];

    for (const key of Object.keys(patch)) {
      if (!allowed.includes(key)) {
        return res.status(400).json({ error: `Ismeretlen mező: ${key}` });
      }
      if (patch[key] != null && typeof patch[key] !== "string") {
        return res.status(400).json({ error: `A '${key}' csak string lehet.` });
      }
    }

    const updated = await repo.updateOne(id, patch);
    if (!updated) return res.status(404).json({ error: "Nincs ilyen gyümölcs." });

    res.json(updated);
  } catch (e) {
    if (e && e.code === "ER_DUP_ENTRY") {
      return res.status(409).json({ error: "Ilyen 'nev' már létezik (UNIQUE)." });
    }
    next(e);
  }
}

async function remove(req, res, next) {
  try {
    const id = parseId(req, res);
    if (!id) return;

    const ok = await repo.deleteOne(id);
    if (!ok) return res.status(404).json({ error: "Nincs ilyen gyümölcs." });

    res.status(204).send();
  } catch (e) {
    next(e);
  }
}

module.exports = { getAll, getById, create, update, remove };
