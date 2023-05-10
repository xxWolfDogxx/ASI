﻿using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASI.Forms.Modification.Story
{
    public partial class ModStory : Form
    {
        public ModStory()
        {
            InitializeComponent();
        }

        private void ModStory_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable dataTableSetup = new DataTable();
            DataTable dataTableRefill = new DataTable();

            adapter.SelectCommand = new MySqlCommand("SELECT setup.id AS 'ID', printer.id AS id_printer, printer.name AS 'Название принтера', cartrige.id AS id_cartrige, cartrige.code AS 'Номер расходника', setup.start AS 'Дата установки', setup.end AS 'Дата снятия', setup.note AS 'Заметки' "+
                        "FROM setup "+
                        "INNER JOIN printer ON setup.id_printer = printer.id "+
                        "INNER JOIN cartrige ON setup.id_cartrige = cartrige.id  WHERE cartrige.id = @idCartrige", db.getConnection());
            adapter.SelectCommand.Parameters.Add("@idCartrige", MySqlDbType.Int32).Value = DataBase.Entity.Setup.Setup.Id_cartrige;
            adapter.Fill(dataTableSetup);

            SetupGridView.DataSource = dataTableSetup;

            SetupGridView.Columns["id_printer"].Visible = false;
            SetupGridView.Columns["id_cartrige"].Visible = false;


            adapter.SelectCommand = new MySqlCommand("SELECT fill.id AS 'ID', cartrige.id AS 'id_cartrige', cartrige.code AS 'Номер картриджа', fill.date AS 'Дата заправки', fill.note AS 'Заметки' " +
                "FROM fill " +
                "INNER JOIN cartrige ON fill.id_cartrige = cartrige.id WHERE cartrige.id = @idCartrige", db.getConnection());
            adapter.SelectCommand.Parameters.Add("@idCartrige", MySqlDbType.Int32).Value = DataBase.Entity.Setup.Setup.Id_cartrige;
            adapter.Fill(dataTableRefill);

            RefillGridView.DataSource = dataTableRefill;
           
            RefillGridView.Columns["id_cartrige"].Visible = false;

        }
    }
}