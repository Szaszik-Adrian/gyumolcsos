require("dotenv").config();

const express = require("express");
const cors = require("cors");
const pool = require("./db/pool");

const fruitsRoutes = require("./routes/fruits.routes");

const app = express();

app.use(cors());
app.use(express.json());

app.get("/dbtest", async (req, res, next) => {
    try {
      const [rows] = await pool.query("SELECT DATABASE() AS db, NOW() AS now");
      res.json(rows[0]);
    } catch (e) {
      next(e);
    }
  });

app.get("/health", (req, res) => res.json({ ok: true }));

app.use("/fruits", fruitsRoutes);

app.use((err, req, res, next) => {
  console.error("DB/API ERROR:", err);
  res.status(500).json({ error: "Szerver hiba.", message: err.message, code: err.code });
});

const port = Number(process.env.PORT || 3000);
app.listen(port, () => console.log(`API fut: http://localhost:${port}`));
