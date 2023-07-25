 //ejercicio 1
        /// Pregunta 1        
        public string deNumATexto(int car)
        {
            string valorTexto;

            switch (car)
            {
                case 1:
                    valorTexto = "un";
                    break;
                case 2:
                    valorTexto = "dos";
                    break;
                case 3:
                    valorTexto = "tres";
                    break;
                case 4:
                    valorTexto = "cuatro";
                    break;
                case 5:
                    valorTexto = "cinco";
                    break;
                case 6:
                    valorTexto = "seis";
                    break;
                case 7:
                    valorTexto = "siete";
                    break;
                default:
                    valorTexto = "Valor no encontrado";
                    break;
            }

            return valorTexto;
        }

        public string pregunta1(string cadena)
        {
            string[] palabras = cadena.Split(' ');
            for (int i = 0; i < palabras.Length; i++)
            {
                if (int.TryParse(palabras[i], out int numero))
                {
                    if (numero >= 1 && numero <= 7)
                    {
                        palabras[i] = deNumATexto(numero);
                    }
                }
            }

            string resultado = string.Join(" ", palabras);
            return resultado;
        }
        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamada pregunta 1
            textBox3.Text = string.Concat(pregunta1(textBox1.Text));
        }


        //ejercicio 2


        public int ejercicio2ef(int n,int n2)
        {
            int d,n3,nn;

            nn = 0;
            while (n > 0)
            {
                d = n % 10;
                n = n / 10;

                if (!(BuscDig(n2,d)))
                {
                    nn = nn * 10 + d;
                }

            }
            return nn;


        }

        public bool BuscDig(int n, int dig)
        {
            bool b;
            int d;
            b = false;

            while ((n > 0) & (b == false))
            {
                d = n % 10;
                n = n / 10;

                if (d == dig)
                    b = true;
            }

            return b;
        }
        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)

        {
            //LLAMADA
            textBox3.Text = string.Concat(ejercicio2ef(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
        }