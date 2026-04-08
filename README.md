# ⚔️ Aelia - RPG Console Edition [WORK IN PROGRESS]
 [![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)

**Aelia** est un jeu de rôle (JDR) textuel développé en **C#** utilisant une architecture **MVC** (Modèle-Vue-Contrôleur) pour garantir un code propre et évolutif.

## 🚀 Fonctionnalités actuelles
- [x] Architecture MVC structurée.
- [x] Système de statistiques avec "garde-fou" (limite à 20).
- [x] Création de personnage (Nom, Race, Classe).
- [x] Système de lancer de dés (`Roll`) avec avantage.

## 🛠️ Installation & Lancement
1. Clonez le dépôt : `git clone https://github.com/912i/Aelia.git`
2. Ouvrez le fichier `Aelia.sln` dans **JetBrains Rider** ou Visual Studio.
3. Compilez et lancez le projet (`F5`).

## 🏗️ Architecture
Le projet suit strictement les principes de la Programmation Orientée Objet :
- **Modèle** : Logique métier, calcul des stats et dés.
- **Vue** : Interactions avec la console.
- **Contrôleur** : Orchestration du flux de jeu.

## 📝 À venir
- [ ] Système de combat au tour par tour.
- [ ] Gestion de l'inventaire et des objets.
- [ ] Dialogues avec les PNJ.

