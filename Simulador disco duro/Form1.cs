using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_disco_duro
{
    public partial class Form1 : Form
    {
        private const int SectorSize = 512;
        private const int MaxSectors = 100;

        private List<FileEntry> files;
        private List<Sector> sectors;

        public Form1()
        {
            InitializeComponent();
            files = new List<FileEntry>();
            sectors = new List<Sector>();
            InitializeSectors();
            UpdateSectorLabels();
        }

        private void InitializeSectors()
        {
            for (int i = 0; i <= MaxSectors; i++)
            {
                sectors.Add(new Sector());
            }
        }

        private void UpdateSectorLabels()
        {
            listViewSectors.Items.Clear();

            for (int i = 0; i < sectors.Count; i++)
            {
                string status = sectors[i].IsOccupied ? "Ocupado" : "Libre";
                string[] row = { i.ToString(), status };
                var listViewItem = new ListViewItem(row);
                listViewSectors.Items.Add(listViewItem);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string fileName = textBoxFileName.Text.Trim();
            int fileSize = Convert.ToInt32(textBoxFileSize.Text);

            if (fileName.Length == 0 || fileSize <= 0)
            {
                MessageBox.Show("Ingresa un nombre de archivo válido y un tamaño mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sectors.Count(s => !s.IsOccupied) == 0)
            {
                MessageBox.Show("No hay suficiente espacio disponible en el disco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (files.Any(f => f.FileName == fileName))
            {
                MessageBox.Show("El nombre de archivo ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int requiredSectors = (int)Math.Ceiling((double)fileSize / SectorSize);

            var freeSectors = sectors.Where(s => !s.IsOccupied).ToList();

            if (freeSectors.Count < requiredSectors)
            {
                MessageBox.Show("No hay suficiente espacio disponible en el disco para almacenar el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var sectorsToOccupy = freeSectors.Take(requiredSectors).ToList();

            FileEntry newFile = new FileEntry(fileName, sectorsToOccupy);
            files.Add(newFile);

            foreach (var sector in sectorsToOccupy)
            {
                sector.IsOccupied = true;
                sector.AssociatedFile = newFile;
            }

            textBoxFileName.Clear();
            textBoxFileSize.Clear();

            UpdateSectorLabels();
            UpdateFileList();
        }

        private void UpdateFileList()
        {
            listViewFiles.Items.Clear();

            var sortedFiles = files.OrderBy(f => f.FileName).ToList();

            foreach (var file in sortedFiles)
            {
                string[] row = { file.FileName, string.Join(", ", file.Sectors.Select(s => s.Index.ToString())) };
                var listViewItem = new ListViewItem(row);
                listViewFiles.Items.Add(listViewItem);
            }
        }
    }

    public class Sector
    {
        public int Index { get; set; }
        public bool IsOccupied { get; set; }
        public FileEntry AssociatedFile { get; set; }

        public Sector()
        {
            IsOccupied = false;
        }
    }

    public class FileEntry
    {
        public string FileName { get; set; }
        public List<Sector> Sectors { get; set; }

        public FileEntry(string fileName, List<Sector> sectors)
        {
            FileName = fileName;
            Sectors = sectors;
        }
    }
}
