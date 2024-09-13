class Livro{
    public string titulo;
    public string autor;
    public int ano;
    public int paginas;

    public void informacoes()
    {
        Console.WriteLine($"Titulo: {titulo}\n");
        Console.WriteLine($"Autor: {autor}\n");
        Console.WriteLine($"Ano: {ano}\n");
        Console.WriteLine($"Paginas: {paginas}\n");
    }

    public bool TemMais300Paginas()
    {
        return paginas > 300;      
    }
}