// See https://aka.ms/new-console-template for more information
using ScacchiC;

Console.WriteLine("Hello, World!");

Scacchiera scacchiera  = new Scacchiera();
Pedina cavallo = new Cavallo("NERO", 3, 3, scacchiera);
Torre torre = new Torre("NERO", 4, 3, scacchiera);
Re re = new Re("NERO", 5, 3, scacchiera);
Alfiere alfiere = new Alfiere("NERO", 6, 4, scacchiera);
Regina regina = new Regina("NERO", 3, 1, scacchiera);
scacchiera.posizionaPedina(3, 3, cavallo);
scacchiera.posizionaPedina(4, 3, torre);
scacchiera.posizionaPedina(5, 3, re);
scacchiera.posizionaPedina(6, 4, alfiere);
scacchiera.posizionaPedina(3, 1, regina);
regina.muovi(7, 5);
scacchiera.visualizza();


/*
 * 2,1
 * 4,1
 * 1,2
 * 5,2
 * 1,4
 * 5,4
 * 2,5
 * 4,5
*/
