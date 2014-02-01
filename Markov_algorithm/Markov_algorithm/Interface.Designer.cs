using System.Drawing;

namespace Markov_algorithm
{
    partial class MarkovForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
<<<<<<< HEAD
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> ad26b91e77ca3114c2893203eea91639e4873a02
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.OpenButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.runButton = new System.Windows.Forms.ToolStripButton();
            this.debugButton = new System.Windows.Forms.ToolStripButton();
            this.StopButton = new System.Windows.Forms.ToolStripButton();
            this.statementTextBox = new System.Windows.Forms.TextBox();
            this.statementLbl = new System.Windows.Forms.Label();
            this.inputLbl = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            this.programGrid = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LeftStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrow = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RightStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.MainMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programGrid)).BeginInit();
            this.programMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(332, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New..";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open..";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as..";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem1,
            this.debugToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // runToolStripMenuItem1
            // 
            this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            this.runToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+F5";
            this.runToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.runToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.runToolStripMenuItem1.Text = "Run";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.debugToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMAToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMAToolStripMenuItem
            // 
            this.aboutMAToolStripMenuItem.Name = "aboutMAToolStripMenuItem";
            this.aboutMAToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutMAToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aboutMAToolStripMenuItem.Text = "About MA";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.OpenButton,
            this.saveButton,
            this.toolStripSeparator2,
            this.runButton,
            this.debugButton,
            this.StopButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(332, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Image = global::Markov_algorithm.Properties.Resources.document_new;
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(23, 22);
            this.NewButton.Text = "New (Ctrl+N)";
            // 
            // OpenButton
            // 
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenButton.Image = global::Markov_algorithm.Properties.Resources.open_document;
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(23, 22);
            this.OpenButton.Text = "Open (Ctrl+O)";
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::Markov_algorithm.Properties.Resources.document_save_as;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 22);
            this.saveButton.Text = "Save (Ctrl+S)";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // runButton
            // 
            this.runButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runButton.Image = global::Markov_algorithm.Properties.Resources.run_single;
            this.runButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(23, 22);
            this.runButton.Text = "toolStripButton4";
            this.runButton.ToolTipText = "Run (Ctrl+F5)";
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // debugButton
            // 
            this.debugButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.debugButton.Image = global::Markov_algorithm.Properties.Resources.run_double;
            this.debugButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(23, 22);
            this.debugButton.Text = "Debug (F5)";
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopButton.Enabled = false;
            this.StopButton.Image = global::Markov_algorithm.Properties.Resources.stop;
            this.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(23, 22);
            this.StopButton.Text = "Stop (Shift+F5)";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // statementTextBox
            // 
            this.statementTextBox.Location = new System.Drawing.Point(12, 68);
            this.statementTextBox.Multiline = true;
            this.statementTextBox.Name = "statementTextBox";
            this.statementTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statementTextBox.Size = new System.Drawing.Size(308, 39);
            this.statementTextBox.TabIndex = 2;
            // 
            // statementLbl
            // 
            this.statementLbl.AutoSize = true;
            this.statementLbl.Location = new System.Drawing.Point(13, 53);
            this.statementLbl.Name = "statementLbl";
            this.statementLbl.Size = new System.Drawing.Size(97, 13);
            this.statementLbl.TabIndex = 3;
            this.statementLbl.Text = "Problem statement:";
            // 
            // inputLbl
            // 
            this.inputLbl.AutoSize = true;
            this.inputLbl.Location = new System.Drawing.Point(13, 115);
            this.inputLbl.Name = "inputLbl";
            this.inputLbl.Size = new System.Drawing.Size(62, 13);
            this.inputLbl.TabIndex = 4;
            this.inputLbl.Text = "Input string:";
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(13, 154);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(70, 13);
            this.outputLbl.TabIndex = 6;
            this.outputLbl.Text = "Output string:";
            // 
            // programGrid
            // 
            this.programGrid.AllowUserToResizeColumns = false;
            this.programGrid.AllowUserToResizeRows = false;
            this.programGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.programGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
<<<<<<< HEAD
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.programGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
=======
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.programGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
>>>>>>> ad26b91e77ca3114c2893203eea91639e4873a02
            this.programGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.programGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.LeftStr,
            this.Arrow,
            this.RightStr});
<<<<<<< HEAD
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.programGrid.DefaultCellStyle = dataGridViewCellStyle11;
=======
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.programGrid.DefaultCellStyle = dataGridViewCellStyle35;
>>>>>>> ad26b91e77ca3114c2893203eea91639e4873a02
            this.programGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.programGrid.EnableHeadersVisualStyles = false;
            this.programGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.programGrid.Location = new System.Drawing.Point(11, 215);
            this.programGrid.MultiSelect = false;
            this.programGrid.Name = "programGrid";
            this.programGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.programGrid.RowHeadersVisible = false;
<<<<<<< HEAD
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.programGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
=======
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.programGrid.RowsDefaultCellStyle = dataGridViewCellStyle36;
>>>>>>> ad26b91e77ca3114c2893203eea91639e4873a02
            this.programGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.programGrid.Size = new System.Drawing.Size(309, 135);
            this.programGrid.TabIndex = 0;
            this.programGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.programGrid_RowsAdded);
            this.programGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.programGrid_RowsRemoved);
            this.programGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.programGrid_KeyDown);
            this.programGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.programGrid_MouseDown);
            // 
            // Number
            // 
            this.Number.Frozen = true;
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Number.Width = 50;
            // 
            // LeftStr
            // 
<<<<<<< HEAD
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftStr.DefaultCellStyle = dataGridViewCellStyle8;
=======
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftStr.DefaultCellStyle = dataGridViewCellStyle32;
>>>>>>> ad26b91e77ca3114c2893203eea91639e4873a02
            this.LeftStr.HeaderText = "Left string";
            this.LeftStr.MaxInputLength = 10;
            this.LeftStr.Name = "LeftStr";
            this.LeftStr.Width = 92;
            // 
            // Arrow
            // 
<<<<<<< HEAD
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrow.DefaultCellStyle = dataGridViewCellStyle9;
=======
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrow.DefaultCellStyle = dataGridViewCellStyle33;
>>>>>>> ad26b91e77ca3114c2893203eea91639e4873a02
            this.Arrow.HeaderText = "Arrow";
            this.Arrow.Items.AddRange(new object[] {
            "→",
            "↦"});
            this.Arrow.Name = "Arrow";
            this.Arrow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Arrow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Arrow.Width = 56;
            // 
            // RightStr
            // 
<<<<<<< HEAD
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightStr.DefaultCellStyle = dataGridViewCellStyle10;
=======
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightStr.DefaultCellStyle = dataGridViewCellStyle34;
>>>>>>> ad26b91e77ca3114c2893203eea91639e4873a02
            this.RightStr.HeaderText = "Right string";
            this.RightStr.Name = "RightStr";
            this.RightStr.Width = 92;
            // 
            // programMenuStrip
            // 
            this.programMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertRowToolStripMenuItem,
            this.deleteRowToolStripMenuItem,
            this.addRowToolStripMenuItem,
            this.clearRowToolStripMenuItem});
            this.programMenuStrip.Name = "programMenuStrip";
            this.programMenuStrip.Size = new System.Drawing.Size(131, 92);
            // 
            // insertRowToolStripMenuItem
            // 
            this.insertRowToolStripMenuItem.Name = "insertRowToolStripMenuItem";
            this.insertRowToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.insertRowToolStripMenuItem.Text = "Insert row";
            this.insertRowToolStripMenuItem.Click += new System.EventHandler(this.insertRowToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addRowToolStripMenuItem.Text = "Add row";
            this.addRowToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // clearRowToolStripMenuItem
            // 
            this.clearRowToolStripMenuItem.Name = "clearRowToolStripMenuItem";
            this.clearRowToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.clearRowToolStripMenuItem.Text = "Clear row";
            this.clearRowToolStripMenuItem.Click += new System.EventHandler(this.clearRowToolStripMenuItem_Click);
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.outputRichTextBox.Location = new System.Drawing.Point(12, 170);
            this.outputRichTextBox.Multiline = false;
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(308, 23);
            this.outputRichTextBox.TabIndex = 9;
            this.outputRichTextBox.Text = "";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 131);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(308, 20);
            this.inputTextBox.TabIndex = 10;
            // 
            // MarkovForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 362);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.programGrid);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.inputLbl);
            this.Controls.Add(this.statementLbl);
            this.Controls.Add(this.statementTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainMenuStrip);
            this.KeyPreview = true;
            this.Name = "MarkovForm";
            this.Text = "Markov algorithms";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programGrid)).EndInit();
            this.programMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton OpenButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton runButton;
        private System.Windows.Forms.ToolStripButton debugButton;
        private System.Windows.Forms.ToolStripButton StopButton;
        private System.Windows.Forms.ToolStripMenuItem aboutMAToolStripMenuItem;
        private System.Windows.Forms.TextBox statementTextBox;
        private System.Windows.Forms.Label statementLbl;
        private System.Windows.Forms.Label inputLbl;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.DataGridView programGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftStr;
        private System.Windows.Forms.DataGridViewComboBoxColumn Arrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightStr;
        private System.Windows.Forms.ContextMenuStrip programMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem insertRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

