namespace LRSV1.Models
{
    public class Ponto
    {
        public Ponto() { }
        public int? Id { get; set; }
        public DateTime Dia { get; set; }
        public TimeSpan HorarioEntrada { get; set; }
        public TimeSpan? HorarioSaida { get; set; }
        public string? ApplicationUserId { get; set; }
         public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
