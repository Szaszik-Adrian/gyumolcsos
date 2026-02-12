const pool = require("../db/pool");

async function findAll() {
  const [rows] = await pool.query(
    `SELECT gyumolcsid, nev, megjegyzes, nev_eng, alt_szoveg, src
     FROM gyumolcs
     ORDER BY gyumolcsid`
  );
  return rows;
}

async function findById(id) {
  const [rows] = await pool.query(
    `SELECT gyumolcsid, nev, megjegyzes, nev_eng, alt_szoveg, src
     FROM gyumolcs
     WHERE gyumolcsid = ?`,
    [id]
  );
  return rows[0] || null;
}

async function insertOne({ nev, megjegyzes = "", nev_eng = null, alt_szoveg, src }) {
  const [result] = await pool.query(
    `INSERT INTO gyumolcs (nev, megjegyzes, nev_eng, alt_szoveg, src)
     VALUES (?, ?, ?, ?, ?)`,
    [nev, megjegyzes, nev_eng, alt_szoveg, src]
  );
  return findById(result.insertId);
}

async function updateOne(id, patch) {
  const current = await findById(id);
  if (!current) return null;

  const next = {
    nev: patch.nev ?? current.nev,
    megjegyzes: patch.megjegyzes ?? current.megjegyzes,
    nev_eng: patch.nev_eng ?? current.nev_eng,
    alt_szoveg: patch.alt_szoveg ?? current.alt_szoveg,
    src: patch.src ?? current.src,
  };

  await pool.query(
    `UPDATE gyumolcs
     SET nev=?, megjegyzes=?, nev_eng=?, alt_szoveg=?, src=?
     WHERE gyumolcsid=?`,
    [next.nev, next.megjegyzes, next.nev_eng, next.alt_szoveg, next.src, id]
  );

  return findById(id);
}

async function deleteOne(id) {
  const [result] = await pool.query(
    `DELETE FROM gyumolcs WHERE gyumolcsid = ?`,
    [id]
  );
  return result.affectedRows > 0;
}

module.exports = { findAll, findById, insertOne, updateOne, deleteOne };
