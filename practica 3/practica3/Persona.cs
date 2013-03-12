using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace practica3
{
    class Persona
    {

        public string codigo;
		public string nombre;
		public string direccion;
		public string facebook;
		public string telefono;

        public Persona()
        {
            this.codigo = "";
            this.nombre = "";
            this.direccion = "";
            this.facebook = "";
            this.telefono = "";
        }
    }
   
      public class creatabla
      {
 
        private Hashtable tabladatos;

        public creatabla()
        {
            this.tabladatos = new Hashtable();
        }

   
        

        


        public void capturar()
        {
           Console.WriteLine("Cuantas personas decea agregar?");
           int  numerodepersonas = Console.Read();

            for (int i = 0; i < numerodepersonas ; i++)
            {
                Console.Clear();
                this.capturarDatosPersona(new Persona());
            }
        }

        private void capturarDatosPersona(Persona persona)
        {
            this.capturarDatos(persona);
            this.agregarPersona(persona);

        }

        private void capturarDatos(Persona persona)
        {
            Console.WriteLine("CAPTURA LOS DATOS DE LA PERSONA");
            if (persona.codigo == "")
            {
                Console.WriteLine("Dame el código");
                persona.codigo = Console.ReadLine();
            }

            Console.WriteLine("Dame el nombre");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("Dame la dirección");
            persona.direccion = Console.ReadLine();
            Console.WriteLine("Dame el teléfono");
            persona.telefono = Console.ReadLine();
            Console.WriteLine("Dame el facebook");
            persona.facebook = Console.ReadLine();
        }

        private void agregarPersona(Persona persona)
        {
            if (this.tabladatos.ContainsKey(persona.codigo))
            {
                this.tabladatos.Remove(persona.codigo);
            }

            this.tabladatos.Add(persona.codigo, persona);
        }

        public void editar()
        {
            Console.WriteLine("cuantos campos desea editar?");
            int personaseditadas = Console.Read();

            for (int i = 0; i < personaseditadas; i++)
            {
                Console.Clear();
                string codigo = "";
                Console.WriteLine("Dame el código para editar");
                codigo = Console.ReadLine();
                if (this.tabladatos.ContainsKey(codigo))
                {
                    Persona persona = (Persona)this.tabladatos[codigo];
                    this.imprimePersona(persona);
                    this.capturarDatosPersona(persona);
                }
                else
                {
                    this.imprimeError();
                }
            }
        }

        public void eliminar()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                string codigo = "";
                Console.WriteLine("Dame el código para eliminar");
                codigo = Console.ReadLine();
                if (this.tabladatos.ContainsKey(codigo))
                {
                    Persona persona = (Persona)this.tabladatos[codigo];
                    this.imprimePersona(persona);
                    this.confirmarEliminacionYEliminar(persona.codigo);
                }
                else
                {
                    this.imprimeError();
                }
            }
        }

        private void confirmarEliminacionYEliminar(string codigo)
        {
            Console.WriteLine("¿Esta seguro que desea eliminar?");
            Console.WriteLine("0 = No, 1 = Si");
            string opcion = Console.ReadLine();
            if (opcion != "0")
            {
                this.tabladatos.Remove(codigo);
            }
        }

        private void imprimeError()
        {
            Console.WriteLine("No existe el código.");
            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadLine();
        }

        public void imprimirTodos()
        {
            ICollection personas = this.tabladatos.Values;

            Console.WriteLine();
            foreach (object objeto in personas)
            {
                Persona persona = (Persona)objeto;
                this.imprimePersona(persona);
            }
        }

        private void imprimePersona(Persona persona)
        {
            Console.WriteLine("Código: " + persona.codigo);
            Console.WriteLine("Nombre: " + persona.nombre);
            Console.WriteLine("Dirección: " + persona.direccion);
            Console.WriteLine("Teléfono: " + persona.telefono);
            Console.WriteLine("Facebook: " + persona.facebook);
            Console.WriteLine("");



        }
    }
  }


