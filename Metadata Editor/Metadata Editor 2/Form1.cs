using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MP3;

namespace Metadata_Editor_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] filepath,filename;
        Metadata[] metadatas;
        int n,selectedIndex;


        void setCommonValue(string name, int col)
        {
            int x, y;
            y = Top - 90 + Height / 2;
            x = Left - 125 + Width / 2;
            ResaultDialog rs = new ResaultDialog(name, x, y);
            rs.ShowDialog();
            int n = dataGridView1.RowCount;
            ;
            if (rs.DialogResult == DialogResult.OK)
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    dataGridView1.SelectedRows[i].Cells[col].Value = rs.getData;
        }
        void getFileName() 
        {
            filename = new string[n];
            string[] temp;
            string sum;
            for (int i = 0; i < n; i++)
            {
                sum = "";
                temp = filepath[i].Split('\\');
                temp = temp[temp.Length - 1].Split('.');
                for(int j=0;j<temp.Length-1;j++)
                    sum = sum + temp[j];
                filename[i] = sum;
            }

     
        }

        void showImage(Image image, String name) {
            label1.Text = name;
            pictureBox1.Image = image;
            button3.Visible = button4.Visible = button5.Visible = label1.Visible = label2.Visible = true;
            if (pictureBox1.Image != null)
            {
                label2.Text = "Розмір: " + pictureBox1.Image.Width.ToString()
                    + "x" + pictureBox1.Image.Height.ToString();

            }

        }

        void showImage(Image image)
        {
            pictureBox1.Image = image;
            button3.Visible = button4.Visible = button5.Visible = label1.Visible = label2.Visible = true;
            if (pictureBox1.Image != null)
            {
                label2.Text = "Розмір: " + pictureBox1.Image.Width.ToString()
                    + "x" + pictureBox1.Image.Height.ToString();

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "mp3 files (*.mp3)|*.mp3";
            fd.Multiselect = true;
            fd.ShowDialog();
            filepath = fd.FileNames;
            readMetadata();
           
        }

        void readMetadata() {
            n = filepath.Length;
            dataGridView1.RowCount = n;
            metadatas = new Metadata[n];
            getFileName();
            for (int i = 0; i < n; i++)
            {
                
                metadatas[i] = MetadataStream.read(filepath[i]);
                dataGridView1[0, i].Value = metadatas[i].name;
                dataGridView1[1, i].Value = metadatas[i].album;
                dataGridView1[2, i].Value = metadatas[i].artist;
                dataGridView1[3, i].Value = metadatas[i].genre;
                dataGridView1[4, i].Value = getTrackNumber(metadatas[i].number);
                dataGridView1[5, i].Value = getTrackCount(metadatas[i].number);
                dataGridView1[6, i].Value = metadatas[i].year;
                dataGridView1.Rows[i].HeaderCell.Value = filename[i];
            }
        }
        string getTrackNumber(string number){
            string[] strings = number.Split('/');
            return strings[0];
        }
        string getTrackCount(string number) {
            string[] strings = number.Split('/');
            if (strings.Length == 2) return strings[1];
            return "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            string[] args = Environment.GetCommandLineArgs();
            string mp3Paths = "";
            if (args.Length > 1) {
                for(int i = 1; i< args.Length;i++){
                    if (args[i].LastIndexOf(".mp3") == args[i].Length - 4) {
                        mp3Paths += args[i]+"\n";
                    }
                }
                filepath = mp3Paths.Split('\n');
                Array.Resize(ref filepath, filepath.Length-1);
                readMetadata();
            }


        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    selectedIndex = dataGridView1.SelectedRows[0].Index;
                    showImage(metadatas[selectedIndex].image, filename[selectedIndex]);
                    
                }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                    contextMenuStrip1.Show(e.Location.X + dataGridView1.Left+this.Left, e.Location.Y + dataGridView1.Top+this.Top);
                else if (dataGridView1.SelectedCells.Count>0)
                    contextMenuStrip2.Show(e.Location.X + dataGridView1.Left + this.Left, e.Location.Y + dataGridView1.Top + this.Top);
            }
        }

        private void виконавецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommonValue("Виконавець", 2);
        }

        private void альбомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommonValue("Виконавець",1);
        }

        private void жанрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommonValue("Жанр", 3);
        }

        private void рікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommonValue("Рік", 6);
        }

        private void кількістьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCommonValue("Кількість", 5);
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                dataGridView1.SelectedCells[i].Value = null;
          
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                dataGridView1.SelectedCells[i].Value = null;
        }


        void renameFile() 
        {
            for (int i = 0; i < n; i++)
            {
                if ((dataGridView1[2, i].Value != null) && (dataGridView1[0, i].Value != null))
                {
                    if ((dataGridView1[2, i].Value != "") && (dataGridView1[0, i].Value != ""))
                    {
                        
                            string newName = dataGridView1[2, i].Value.ToString() + " - " + dataGridView1[0, i].Value.ToString();
                            int ind = filepath[i].LastIndexOf('\\');
                            string newPath = filepath[i].Remove(ind + 1) + newName + ".mp3";
                            try {
                                File.Move(filepath[i], newPath);
                                filepath[i] = newPath;
                                filename[i] = newName;
                                dataGridView1.Rows[i].HeaderCell.Value = filename[i];
                            } catch(Exception e){
                                MessageBox.Show("Не вдалося перейменувати файл " + newName + "\nоскільки він відкритий в іншій програмі");
                        }
                    }
                }
            }
        }

        string getGridValue(int column, int row)
        {
            if (dataGridView1[column, row].Value != null)
                if (dataGridView1[column, row].Value.ToString() != "")
                    return dataGridView1[column, row].Value.ToString();            
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                metadatas[i].name = getGridValue(0,i);
                metadatas[i].album = getGridValue(1, i);
                metadatas[i].artist = getGridValue(2, i);
                metadatas[i].genre = getGridValue(3, i);
                metadatas[i].number = getGridValue(4, i) + "/" + getGridValue(5, i);
                metadatas[i].year = getGridValue(6, i);
                MetadataStream.write(filepath[i], metadatas[i]);
            }
            renameFile();

            /*for (int i = 0; i < n; i++)
            {
                file[i].name = getGridValue(0, i);
                file[i].album = getGridValue(1, i);                
                file[i].artist = getGridValue(2, i);
                file[i].genre = getGridValue(3, i);                
                file[i].setTrackNumber(getGridValue(4, i), getGridValue(5, i));
                file[i].year = getGridValue(6, i);
                file[i].write();    
            }
           */
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "Image Files (*.jpg,*.bmp,*.png )|*.jpg;*.bmp;*.png";
                fd.ShowReadOnly = true;
                fd.ShowDialog();
                metadatas[selectedIndex].image = Image.FromFile(fd.FileName);
                showImage(metadatas[selectedIndex].image);
            }
            catch { MessageBox.Show("Невдалось відкрити зображення"); }
        }

        private void зображенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index=0;
            try
            {           
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files (*.jpg,*.bmp,*.png )|*.jpg;*.bmp;*.png";
            fd.ShowReadOnly = true;
            fd.ShowDialog();
            selectedIndex = dataGridView1.SelectedRows[0].Index;
            showImage(Image.FromFile(fd.FileName), filename[selectedIndex]);
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                index = dataGridView1.SelectedRows[i].Index;
                metadatas[index].image = pictureBox1.Image;
                }
            
            }
            catch { MessageBox.Show("Невдалось відкрити зображення"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetImage() == null)
            {
                MessageBox.Show("Буфер зображень порожній");
            }
            else {
                showImage(Clipboard.GetImage());
                metadatas[selectedIndex].image = pictureBox1.Image;
               

            }
              
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Clipboard.SetImage(pictureBox1.Image);
            }
        }

        private void буферToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetImage() == null)
            {
                MessageBox.Show("Буфер зображень порожній");
            }
            else
            {
            int index = 0;
            showImage(Clipboard.GetImage(), filename[selectedIndex]);
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    index = dataGridView1.SelectedRows[i].Index;
                    metadatas[index].image = pictureBox1.Image;
                }

            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }


    }
}
