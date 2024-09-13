# 🎶 Spotilike - Le Spotify amélioré

**Spotilike** est une version améliorée de Spotify où vous pouvez gérer vos artistes, albums, genres et morceaux préférés ! Ce projet met en avant l'implémentation d'un système de gestion musicale en utilisant ASP.NET Core, Angular, et diverses technologies modernes.

## 🚀 Fonctionnalités

- **Opérations CRUD :**
  - **Artistes** : Créer, lire, mettre à jour et supprimer des artistes.
  - **Genres** : Gérer les différents genres musicaux.
  - **Albums** : Ajouter, éditer et supprimer des albums.
  - **Morceaux** : En cours de développement, la fonctionnalité CRUD complète sera disponible prochainement !

- **Authentification JWT** : Système de connexion sécurisé mis en place avec les JSON Web Tokens (JWT).
- **Configuration CORS** : Gestion correcte des requêtes Cross-Origin pour permettre une interaction fluide entre le frontend et le backend.
- **Déploiement Backend** : Déployé avec succès sur **Azure App Service**.

## 🛠️ Technologies Utilisées

### Backend :
- **ASP.NET Core 6**
- **Entity Framework Core** avec **MySQL**
- **Authentification JWT**
- **Azure App Service** pour le déploiement

### Frontend :
- **Angular** (v14)
- **Bootstrap** pour un design réactif
- **HttpClient** pour l'interaction avec l'API

## 🌐 Exécuter le Projet en Local

### Prérequis
- Installer le [SDK .NET Core](https://dotnet.microsoft.com/download)
- Installer [Node.js](https://nodejs.org/)
- Installer [MySQL](https://www.mysql.com/) pour la base de données

### Configuration Backend
- Lancer les migrations pour mettre en place le schéma de la base de données :

bash
```
dotnet ef database update
```

- Démarrer le backend :
bash
```
dotnet run
```

## 🧑‍💻 Comment Utiliser

- **S'inscrire/Se connecter** : Utilisez le système d'authentification pour vous connecter.
- **Gérer les Artistes, Albums et Genres** : Vous pouvez créer, modifier et supprimer des artistes, albums et genres.

## 🔧 Améliorations Futures

- Résoudre les problèmes de gestion Morceaux (CRUD).
- Déploiement complet du frontend sur Azure.

## 🌐 Démo en Ligne

- Le backend est déployé et opérationnel sur Azure. Découvrez-le ici : https://spotilikewebapp-ete2amdtacc3dxcv.francecentral-01.azurewebsites.net/api/albums
- Le frontend est en cours de déployment
- Un fois lancé le projet vous pouvez tester avec swagger: https://localhost:7286/swagger/index.html
