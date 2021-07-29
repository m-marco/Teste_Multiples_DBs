namespace Domain
{
    public class Tarefa
    {
        public int TarefaId { get; set; }
        public int UsuarioId { get; set; }
        public string Nome { get; set; }

        public virtual UsuarioInterno Usuario { get; set; }
    }
}
