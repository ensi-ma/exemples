using MaBanque;

Compte omar = new Compte(1, "Omar", 1000);
Compte ali = new Compte(2, "Ali", 500);
// Start
omar.Afficher();
ali.Afficher();

omar.Debiter(300);
omar.Virement(ali, 500);
ali.Debiter(800);

omar.Afficher();
ali.Afficher();
