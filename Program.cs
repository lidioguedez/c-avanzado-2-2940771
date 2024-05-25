
namespace Avanzado2_2
{
    class Program
    {
        public class Peticion
        {
            internal int Puerto { get; set; }
            internal string Metodo { get; set; }
            internal string TipoDeContenido { get; set; }
        }
        
        static void Main()
        {
            bool procesarPeticion(Peticion pet) => pet switch
            {
                { TipoDeContenido: "image/*", Metodo:"GET"} => true,
                { Puerto:8080 , Metodo: string { Length:2 }} => true,
                { TipoDeContenido: "image/*", Metodo:"POST" } when pet.Puerto.ToString().Length <= 4 => true,
                { Metodo:"PUT", Puerto: 3000, TipoDeContenido: string tc } => tc.EndsWith("*"), _ => false
            };

        }
    }
}