using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone meuIphone =  new Iphone("1234","14","asdf",128);

meuIphone.Ligar();
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("I Am Rich");

Nokia meuNokia = new Nokia("5678","15","ghijk",64);

meuNokia.Ligar();
meuNokia.ReceberLigacao();
meuNokia.InstalarAplicativo("Super Mario Bros");