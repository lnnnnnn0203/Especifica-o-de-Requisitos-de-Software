namespace Template; 

public class Template
{
  public int data { get; set; }
public string Versão { get; set; }
public string descrição { get; set; }
public string autor { get; set; }

public Template(int data, string Versão, string descrição, string autor)
{
  this.data = data;
  this.Versão = Versão;
  this.descrição = descrição;
  this.autor = autor;
    
}
}

