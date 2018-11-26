# TP3-PictureViewer
>[Fichiers de départ (accès direct sans colnet)](https://drive.google.com/drive/folders/1O8XfnquVcuIaFSfSgspYtr0p6tHl4fIo?usp=sharing)

>[Graphique interactif sur le flow du developpement GitHub](https://guides.github.com/introduction/flow/)

>[Mise en forme](https://help.github.com/articles/basic-writing-and-formatting-syntax/)

>[Glossaire GitHub](https://help.github.com/articles/github-glossary/)

>[Comment utiliser GitHub](https://guides.github.com/activities/hello-world/)

>[Extension GitHub pour Visual Studio](https://visualstudio.github.com/)

>[Créer un *repository* GitHub avec Visual Studio](https://www.infragistics.com/community/blogs/b/dhananjay_kumar/posts/step-by-step-working-with-github-repository-and-visual-studio-2015)
------------------------------------------------------------------------------------
Énoncé
------------------------------------------------------------------------------------
À partir des ressources fournies en classe concernant le serveur de photo, (re)concevoir et bâtir
l’interface utilisateur d’une application cliente de gestion de photographies conviviale, attrayante et
souple. Vous avez carte blanche en ce qui concerne le choix des contrôles et l’aspect général de
l’interface en autant que certains éléments énumérés plus bas s’y retrouvent.

------------------------------------------------------------------------------------
Compétences
------------------------------------------------------------------------------------
- Concevoir et bâtir une interface utilisateur conviviale
	- Bâtir les prototypes des dialogues
	- Mise en œuvre
- Faire les choix judicieux des contrôles utilisateurs
- Maintenir la cohérence des contrôles
- Assurer la qualité des données fournies par l’usager
- Implanter la rétention des réglages utilisateurs
- Utilisation d’une minuterie
- Menu contextuel
- Fenêtre de dialogue adaptive à sa taille

------------------------------------------------------------------------------------
Liste des fonctionnalités (**Voir [Projet](https://github.com/UITeamwork/TP3-PictureViewer/projects/4) pour liste des choses à faire**)
------------------------------------------------------------------------------------
- Gestion de compte
	- Login
	- Profil
	- Création
	- Retrait
- Gestion des photos
	- Ajout
	- Modification de la photo propriétaire sélectionnée
	- Retrait de la photo propriétaire sélectionnée
	- Voir/masquer le dialogue non modal sur les informations de la photo sélectionnée
		- Propriétaire (nom, avatar)
		- Titre, description, date de création, mots-clés
		- Dimensions en pixels
		- Partagée, privée
- Filtres (vous devez innover sur ce point)
	- Par mots-clés
	- Par usagers
	- Par intervalle de dates
- Exploitation du contrôle de saisie de photo (ImageBox)
	- Ajouter un item de menu contextuel « Rotation »
	- Implanter la rotation d’image
- Exploitation du fureteur de photos (PhotoBrowser)
- Gestion d’une « liste noire » d’usagers (masquer leurs photos en tout temps)
	- Ajout/retrait
	- Réinitialisation
- Gestion de la liste des photos du « carrousel » (slide-show)
	- Ajout/retrait
	- Réinitialisation
- Visionnement du carrousel en boucle perpétuelle dans une fenêtre à part
	- Consécutivement ou aléatoirement
	- Vitesse variable par l’usager
- Conservation des réglages suivants
	- Taille et position de tous les dialogues
	- Placement du fureteur de photos (gauche, droit, haut, bas)
	- Nom d’usager et mot de passe (« se souvenir de moi »)
	- La « liste noire » d’usagers
	- Liste des photos du « carrousel »
- Menu « à propos » donnant accès au dialogue qui présente les auteurs de l’application
- Menu d’aide donnant accès au dialogue d’aide sur les fonctionnalités de l’application

------------------------------------------------------------------------------------
Contraintes
------------------------------------------------------------------------------------
- Commandes via menu, clavier et boutons flash
- Info-bulle pour tous les boutons flash
- Offrir au moins deux méthodes pour toutes commandes
- Dialogue adaptif à sa taille
- Vous ne devez pas outrepasser vos droits sur les données du serveur de photos
	- Modifier/effacer une photo dont vous n’êtes pas propriétaire
	- Modifier/effacer un compte que vous n’avez pas créé

------------------------------------------------------------------------------------
Calendrier (toutes ses rencontres sont obligatoires)
------------------------------------------------------------------------------------
- Mercredi 14 novembre - soumission de ce travail - formation des équipes
- Lundi 19 novembre - rencontre de conception
- Mercredi 21 novembre – approbation des prototypes
- Lundi 26 novembre – programmation / consultation
- Mercredi 8 novembre – programmation / consultation
- Lundi 3 décembre – présentations / évaluations en classe, dépôt dans Colnet avant minuit

------------------------------------------------------------------------------------
Critères d’évaluation
------------------------------------------------------------------------------------
- Respect des spécifications 20 pts
- Fonctionnement sans faille 20 pts
- Mise en page des formulaires 15 pts
- Cohérence de l’interface 15 pts
- Validation et filtre des données 10 pts
- Convivialité / clarté / esthétisme 20 pts
- Innovation (points bonis) 10 pts


//Pour du temps a perdre : https://www.nirsoft.net/
