using System.Web;

namespace lab7_perelygin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] countries = { "Бразилия", "Аргентина", "Чили", "Уругвай", "Колумбия" };
            listBox1.Items.AddRange(countries);
            string[] countries2 = { "Россия", "Испания", "Германия", "Норвегия", "Швейцария" };
            listBox2.Items.AddRange(countries2);
        }

        private void button1_Click(object sender, EventArgs e) // 1 элемент в правый список
        {
            var selectedItems = listBox1.SelectedItems;

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add(selectedItems[i]);
                listBox1.Items.Remove(selectedItems[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e) // 1 элемент в левый список
        {
            var selectedItems = listBox2.SelectedItems;

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(selectedItems[i]);
                listBox2.Items.Remove(selectedItems[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Все элементы в правый список
        {
            var selectedItems = listBox1.Items;

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add(selectedItems[i]);
                listBox1.Items.Remove(selectedItems[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e) // Все элементы в левый список
        {
            var selectedItems = listBox2.Items;

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(selectedItems[i]);
                listBox2.Items.Remove(selectedItems[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e) // Кнопка reset
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string[] countries = { "Бразилия", "Аргентина", "Чили", "Уругвай", "Колумбия" };
            listBox1.Items.AddRange(countries);
            string[] countries2 = { "Россия", "Испания", "Германия", "Норвегия", "Швейцария" };
            listBox2.Items.AddRange(countries2);
        }

        private void button5_Click(object sender, EventArgs e) // Кнопка save
        {
            string result="";
            if (listBox2.Items.Count == 0)
                MessageBox.Show($"Нет выбранных элементов");
            else
            {
                foreach(var item in listBox2.Items)
                    result += $"{item.ToString()}\n";
                MessageBox.Show($"Выбранные страны:\n{result}");
            }    
                
        }
    }
}
