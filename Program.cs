Livro l1 = new Livro();
l1.titulo = "Harry Potter e a Pedra Filosofal";
l1.autor = "J.K. Rowling";
l1.ano = 1997;
l1.paginas = 208;

l1.informacoes();

l1.TemMais300Paginas();
if(l1.TemMais300Paginas())
{
    Console.WriteLine("Tem mais de 300 páginas!");
}else{
    Console.WriteLine("Tem menos de 300 páginas!");
}
