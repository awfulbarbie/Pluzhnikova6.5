namespace lab6._4_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[][] Input()
            {
                int n = 0;
                
                    try
                    {
                        if (numericUpDown1.Value <= 0)
                        {
                            MessageBox.Show("Ошибка! Размерность массива не может иметь отрицательное или нулевое значение", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Environment.Exit(0);
                        }
                    }
                    catch
                    {
                         MessageBox.Show("Ошибка! Неверный формат ввода данных", "Ошибка",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                         Environment.Exit(0);
                    }
                n = (int)numericUpDown1.Value;

                int[][] array = new int[n][];               //Ступенчатый массив - массив массивов, в котором длина каждого массива может быть разной.
                Random rand = new Random();                 //Ступенчатый массив может быть использован для составления таблицы из строк разной длины.
                for (int i = 0; i < n; i++)
                {
                    array[i] = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        array[i][j] = rand.Next(-100, 100);
                    }

                }
                return array;
            }

            void Print1(int[][] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    textBox1.Text += Environment.NewLine;
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        textBox1.Text += $"{array[i][j]} ";
                    }

                }
                textBox1.Text += Environment.NewLine;
            }

            void Print2(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    textBox2.Text += $"{array[i]}   ";
                }
            }

            int Min(int[] array)
            {
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                    //else
                    //{
                    //    MessageBox.Show("Нет минимального");        //остановка программы
                    //}
                }
                return min;
            }

            int[] Multiply(int[][] array)
            {
                int[] mult = new int[array.GetLength(0)];       //Размерность массива mult равна размерности строки массива array
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    mult[i] = 1;
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        mult[i] *= array[j][i];
                    }
                }
                return mult;
            }

            {
                int[][] Array = Input();
                Print1(Array);
                int[] mult = new int[Array.Length];
                mult = Multiply(Array);
                Print2(mult);
                int min = Min(mult);
                textBox3.Text += $"Минимальный элемент нового массива: {min}";

            }
        }
    }

}
    
