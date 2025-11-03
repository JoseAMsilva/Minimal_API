namespace MinimalApi.Dominio.ModelViews;
public struct Home
{
    public readonly string Mensagem { get => "Bem vindo ao Minimal API de Veículos!"; }
    public readonly string Doc{ get => "/swagger";  }
}