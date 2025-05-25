# Jumping Agent - ML Agent Project

Dit project gebruikt Unity ML-Agents om een simpele AI te trainen die leert om over obstakels te springen. De AI leert zelf wanneer het het beste moment is om te springen om niet tegen een obstakel te botsen.

---

## 🎮 Wat doet de AI?

De AI bestuurt een kubus (de agent) die over een obstakel moet springen. Het obstakel komt van rechts naar links en beweegt met een willekeurige snelheid. De agent krijgt beloningen en straffen om te leren:

- ✅ Beloning voor elke seconde dat hij niet botst
- ✅ Grote beloning als hij een obstakel ontwijkt
- ❌ Straf als hij botst of valt
- ❌ Kleine straf voor nutteloos springen

---

## 🧠 Training met ML-Agents

We gebruiken Unity ML-Agents voor het trainen van het model. Observaties die de agent ontvangt zijn onder andere:
- Is hij op de grond?
- Zijn verticale snelheid
- Afstand tot het obstakel

Tijdens de training werd gebruik gemaakt van PPO (Proximal Policy Optimization).

---

## 📊 TensorBoard Resultaat

Hieronder zie je de training in TensorBoard:

(moet ik nog toevoegen)

**Analyse:**
- De cumulatieve reward stijgt langzaam en toont een leerproces.
- De AI had een dip bij ~20k stappen, maar herstelde zich.
- Op het einde van de training zit de gemiddelde reward rond de **3.2**, wat betekent dat de agent regelmatig obstakels weet te ontwijken.

---

## 🛠️ Zelf proberen?

### 1. Clone deze repo

```bash
git clone https://github.com/AP-IT-GH/labo-03-jumper-zakaria12345688.git

