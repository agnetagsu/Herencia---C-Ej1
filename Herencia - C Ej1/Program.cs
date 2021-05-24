using System;

namespace Herencia___C_Ej1
{
    class Cuenta
    {
        public string nombre { get; set; }
        public double cantidad { get; set; }

        public Cuenta(string nnombre)
        {
            nombre = nnombre;
            cantidad = 0;
        }
        public Cuenta(string nnombre, double ncantidad)
        {
            nombre = nnombre;
            cantidad = ncantidad;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", nombre,cantidad);
        }

        public void ingresar (double ncantidad)
        {
            if (ncantidad > 0)
            {
                cantidad = cantidad + ncantidad;
            }
        }
        public void retirar (double ncantidad)
        {
            if(cantidad <= ncantidad)
            {
                cantidad = 0;
            }
            else
            {
                cantidad = cantidad - ncantidad;
            }
        }



        static void Main(string[] args)
        {
            Cuenta count = new Cuenta("Jose Luis Vilchez", 3009.09);

            Console.WriteLine(count.ToString());
            count.ingresar(1000);
            Console.WriteLine(count.ToString());
            count.retirar(4000);
            Console.WriteLine(count.ToString());


        }
    }
}
