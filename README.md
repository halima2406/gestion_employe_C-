# GesEmpAspNet - Gestion des Employés et Départements

Application ASP.NET Core MVC avec pagination fonctionnelle et base de données MySQL.

## 🚀 INSTALLATION ET DÉMARRAGE

### ÉTAPE 1 : Restaurer les packages
```bash
dotnet restore
```

### ÉTAPE 2 : Vérifier la connexion MySQL
Ouvrez `Data/GesEmpDbContext.cs` et vérifiez :
```csharp
"Server=localhost;Port=8889;Database=GesEmpDB;User=root;Password=root;"
```

### ⚠️ ÉTAPE 3 : CRÉER LA MIGRATION (À FAIRE MAINTENANT)
```bash
dotnet ef migrations add InitialCreate
```

### ⚠️ ÉTAPE 4 : CRÉER LA BASE DE DONNÉES (À FAIRE MAINTENANT)
```bash
dotnet ef database update
```

### ÉTAPE 5 : Ajouter des données de test (optionnel)
Ouvrez phpMyAdmin et exécutez :

```sql
-- Insérer des départements
INSERT INTO departements (Nom, NbreEmploye, DateCreation, Statut) VALUES
('RH', 0, '2025-11-27', 'Actif'),
('DSI', 0, '2025-11-26', 'Actif');

-- Insérer des employés/comptes
INSERT INTO employes (NumeroCompte, Titulaire, Type, Solde, DateCreation, Statut, DepartementId) VALUES
('C00123456', 'Amadou Diallo', 'Épargne', 1250000, '2023-03-15', 'Ouvert', 1),
('C00123457', 'Fatou Ndiaye', 'Chèque', 3750000, '2023-01-02', 'Actif', 1),
('C00123458', 'Moussa Sow', 'Épargne', 850000, '2023-04-10', 'Actif', 2),
('C00123459', 'Aissatou Diop', 'Chèque', 2100000, '2023-02-22', 'Actif', 2);
```

### ÉTAPE 6 : Lancer l'application
```bash
dotnet run
```

Ouvrez votre navigateur : **http://localhost:5016**

## ✅ FONCTIONNALITÉS

### **Implémenté**
- ✅ Navigation Dashboard / Departement / Employes
- ✅ Liste des départements avec données de la BD
- ✅ **Pagination fonctionnelle** sur les départements
- ✅ Liste des employés avec données de la BD
- ✅ **Pagination fonctionnelle** sur les employés
- ✅ **Bouton "Employes"** qui redirige vers la liste filtrée
- ✅ Interface moderne Bootstrap

### **Non implémenté (à faire plus tard)**
- ❌ Recherche
- ❌ Filtres (Type de compte, Trier par)
- ❌ Création de départements/employés
- ❌ Modification/Suppression

## 📁 Structure

```
GesEmpAspNet/
├── Controllers/
│   ├── DashboardController.cs
│   ├── DepartementController.cs  (avec pagination)
│   └── EmployeController.cs      (avec pagination)
├── Models/
│   ├── Departement.cs
│   └── Employe.cs
├── Data/
│   └── GesEmpDbContext.cs
├── Services/
│   ├── IDepartementService.cs
│   ├── IEmployeService.cs
│   └── Impl/
│       ├── DepartementService.cs (pagination)
│       └── EmployeService.cs     (pagination)
└── Views/
    ├── Departement/Index.cshtml
    ├── Employe/Index.cshtml
    └── Dashboard/Index.cshtml
```

## 🗄️ Base de Données

### Table `departements`
- Id, Nom, NbreEmploye, DateCreation, Statut

### Table `employes`
- Id, NumeroCompte, Titulaire, Type, Solde, DateCreation, Statut, DepartementId

## 👨‍💻 Auteur
Halima Léna Camara
