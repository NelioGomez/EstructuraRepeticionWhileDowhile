namespace ControlFactrua
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblMonto.Text = (0).ToString("C");
        }

        private void btnRegistrarItem_Click(object sender, EventArgs e)
        {
            int i;

            //Capturando los datos
            int numfact = int.Parse(txtNumFact.Text);
            string licencia = cboTipo.Text;
            int unidades = int.Parse(txtUnidades.Text);

            //Determinar el precio de las licencias
            double precio = 0;
            switch (licencia)
            {
                case "Cobre": precio = 700; break;
                case "Bronce": precio = 900; break;
                case "Silver": precio = 1400; break;
                case "Gold": precio = 2500; break;
            }

            //Calculando el subtotal
            double subtotal = unidades * precio;

            //envaindo la informacion a la lista de registros
            ListViewItem fila = new ListViewItem(numfact.ToString());
            fila.SubItems.Add(licencia);
            fila.SubItems.Add(unidades.ToString());
            fila.SubItems.Add(subtotal.ToString("0.00"));
            lvRegistro.Items.Add(fila);

            //Calculando el monto total acumulado
            double mAcumulado = 0;
            i = 0;
            while (i < lvRegistro.Items.Count)
            {
                mAcumulado += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
                i++;
            }
            lblMonto.Text = mAcumulado.ToString("C");

            //Calculando las estadisticas
            int cCobre = 0, cBronce = 0, cSilver = 0, cGold = 0;
            double tCobre = 0, tBronce = 0, tSilver = 0, tGold = 0;

            i = 0;
            do
            {
                if (lvRegistro.Items[i].SubItems[1].Text == "Cobre")
                {
                    cCobre += int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                    tCobre += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
                }

                if (lvRegistro.Items[i].SubItems[1].Text == "Bronce")
                {
                    cBronce += int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                    tBronce += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
                }

                if (lvRegistro.Items[i].SubItems[1].Text == "Silver")
                {
                    cSilver += int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                    tSilver += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
                }

                if (lvRegistro.Items[i].SubItems[1].Text == "Gold")
                {
                    cGold += int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                    tGold += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
                }

                i++;
            } while (i < lvRegistro.Items.Count);

            //Imprimiendo estadisticas
            lvEstadistica.Items.Clear();
            string[] elementosfila = new string[3];
            ListViewItem row;

            //1er Elemento
            elementosfila[0] = "Total Cobre";
            elementosfila[1] = cCobre.ToString();
            elementosfila[2] = tCobre.ToString();
            row = new ListViewItem(elementosfila);
            lvEstadistica.Items.Add(row);

            //2do Elemento
            elementosfila[0] = "Total Bronce";
            elementosfila[1] = cBronce.ToString();
            elementosfila[2] = tBronce.ToString();
            row = new ListViewItem(elementosfila);
            lvEstadistica.Items.Add(row);

            //3er Elemento
            elementosfila[0] = "Total Silver";
            elementosfila[1] = cSilver.ToString();
            elementosfila[2] = tSilver.ToString();
            row = new ListViewItem(elementosfila);
            lvEstadistica.Items.Add(row);

            //4to Elemento
            elementosfila[0] = "Total Gold";
            elementosfila[1] = cGold.ToString();
            elementosfila[2] = tGold.ToString();
            row = new ListViewItem(elementosfila);
            lvEstadistica.Items.Add(row);

        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            txtNumFact.Clear();
            txtUnidades.Clear();
            cboTipo.Text = "(Seleccion licencia)";
            txtNumFact.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro que desea salir?",
                                         "Control de registro de Factura",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}