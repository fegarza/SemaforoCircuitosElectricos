namespace CircuitosProgramables_Semaforo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcxd = new System.Windows.Forms.PictureBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.picBxSemaforoOeste = new System.Windows.Forms.PictureBox();
            this.picBxSemaforoSur = new System.Windows.Forms.PictureBox();
            this.picBxSemaforoEste = new System.Windows.Forms.PictureBox();
            this.picBxSemaforo = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblContador = new System.Windows.Forms.Label();
            this.pcFondo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpreventivas = new ePOSOne.btnProduct.Button_WOC();
            this.btntick = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.btndetenre = new ePOSOne.btnProduct.Button_WOC();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcxd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSemaforoOeste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSemaforoSur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSemaforoEste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSemaforo)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFondo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CircuitosProgramables_Semaforo.Properties.Resources.fondoAnimado;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pcxd);
            this.panel2.Controls.Add(this.bindingNavigator1);
            this.panel2.Controls.Add(this.picBxSemaforoOeste);
            this.panel2.Controls.Add(this.picBxSemaforoSur);
            this.panel2.Controls.Add(this.picBxSemaforoEste);
            this.panel2.Controls.Add(this.picBxSemaforo);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.pcFondo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 749);
            this.panel2.TabIndex = 2;
            // 
            // pcxd
            // 
            this.pcxd.Image = ((System.Drawing.Image)(resources.GetObject("pcxd.Image")));
            this.pcxd.Location = new System.Drawing.Point(11, 105);
            this.pcxd.Name = "pcxd";
            this.pcxd.Size = new System.Drawing.Size(1, 1);
            this.pcxd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcxd.TabIndex = 12;
            this.pcxd.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(10, 10);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1367, 25);
            this.bindingNavigator1.TabIndex = 11;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // picBxSemaforoOeste
            // 
            this.picBxSemaforoOeste.BackColor = System.Drawing.Color.Transparent;
            this.picBxSemaforoOeste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBxSemaforoOeste.Location = new System.Drawing.Point(434, 301);
            this.picBxSemaforoOeste.Name = "picBxSemaforoOeste";
            this.picBxSemaforoOeste.Size = new System.Drawing.Size(140, 65);
            this.picBxSemaforoOeste.TabIndex = 7;
            this.picBxSemaforoOeste.TabStop = false;
            // 
            // picBxSemaforoSur
            // 
            this.picBxSemaforoSur.BackColor = System.Drawing.Color.Transparent;
            this.picBxSemaforoSur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxSemaforoSur.Location = new System.Drawing.Point(561, 634);
            this.picBxSemaforoSur.Name = "picBxSemaforoSur";
            this.picBxSemaforoSur.Size = new System.Drawing.Size(65, 140);
            this.picBxSemaforoSur.TabIndex = 10;
            this.picBxSemaforoSur.TabStop = false;
            // 
            // picBxSemaforoEste
            // 
            this.picBxSemaforoEste.BackColor = System.Drawing.Color.Transparent;
            this.picBxSemaforoEste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxSemaforoEste.Location = new System.Drawing.Point(910, 580);
            this.picBxSemaforoEste.Name = "picBxSemaforoEste";
            this.picBxSemaforoEste.Size = new System.Drawing.Size(140, 65);
            this.picBxSemaforoEste.TabIndex = 9;
            this.picBxSemaforoEste.TabStop = false;
            // 
            // picBxSemaforo
            // 
            this.picBxSemaforo.BackColor = System.Drawing.Color.Transparent;
            this.picBxSemaforo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxSemaforo.Location = new System.Drawing.Point(852, 187);
            this.picBxSemaforo.Name = "picBxSemaforo";
            this.picBxSemaforo.Size = new System.Drawing.Size(65, 130);
            this.picBxSemaforo.TabIndex = 7;
            this.picBxSemaforo.TabStop = false;
            this.picBxSemaforo.Click += new System.EventHandler(this.picBxSemaforo_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.lblContador);
            this.panel5.Location = new System.Drawing.Point(632, 359);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(119, 114);
            this.panel5.TabIndex = 6;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Digital-7", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.Gray;
            this.lblContador.Location = new System.Drawing.Point(18, 8);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(85, 96);
            this.lblContador.TabIndex = 4;
            this.lblContador.Text = "0";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcFondo
            // 
            this.pcFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcFondo.BackgroundImage")));
            this.pcFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcFondo.Image = global::CircuitosProgramables_Semaforo.Properties.Resources.fondoAnimado;
            this.pcFondo.Location = new System.Drawing.Point(0, 0);
            this.pcFondo.Margin = new System.Windows.Forms.Padding(0);
            this.pcFondo.Name = "pcFondo";
            this.pcFondo.Size = new System.Drawing.Size(1368, 747);
            this.pcFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFondo.TabIndex = 3;
            this.pcFondo.TabStop = false;
            this.pcFondo.Click += new System.EventHandler(this.pcFondo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.btnpreventivas);
            this.panel1.Controls.Add(this.btntick);
            this.panel1.Controls.Add(this.button_WOC2);
            this.panel1.Controls.Add(this.btndetenre);
            this.panel1.Location = new System.Drawing.Point(330, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 77);
            this.panel1.TabIndex = 17;
            // 
            // btnpreventivas
            // 
            this.btnpreventivas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnpreventivas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btnpreventivas.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(194)))), ((int)(((byte)(181)))));
            this.btnpreventivas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnpreventivas.FlatAppearance.BorderSize = 0;
            this.btnpreventivas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnpreventivas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnpreventivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpreventivas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpreventivas.Location = new System.Drawing.Point(15, 12);
            this.btnpreventivas.Name = "btnpreventivas";
            this.btnpreventivas.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btnpreventivas.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btnpreventivas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnpreventivas.Size = new System.Drawing.Size(143, 53);
            this.btnpreventivas.TabIndex = 13;
            this.btnpreventivas.Text = "PREVENTIVAS";
            this.btnpreventivas.TextColor = System.Drawing.Color.White;
            this.btnpreventivas.UseVisualStyleBackColor = false;
            this.btnpreventivas.Click += new System.EventHandler(this.btnpreventivas_Click);
            // 
            // btntick
            // 
            this.btntick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btntick.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btntick.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(194)))), ((int)(((byte)(181)))));
            this.btntick.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btntick.FlatAppearance.BorderSize = 0;
            this.btntick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btntick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btntick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntick.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntick.Location = new System.Drawing.Point(550, 12);
            this.btntick.Name = "btntick";
            this.btntick.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btntick.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btntick.OnHoverTextColor = System.Drawing.Color.White;
            this.btntick.Size = new System.Drawing.Size(143, 53);
            this.btntick.TabIndex = 16;
            this.btntick.Text = "TICK";
            this.btntick.TextColor = System.Drawing.Color.White;
            this.btntick.UseVisualStyleBackColor = false;
            this.btntick.Click += new System.EventHandler(this.btntick_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.button_WOC2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.button_WOC2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(194)))), ((int)(((byte)(181)))));
            this.button_WOC2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.button_WOC2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.Location = new System.Drawing.Point(196, 12);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC2.Size = new System.Drawing.Size(143, 53);
            this.button_WOC2.TabIndex = 14;
            this.button_WOC2.Text = "INICIAR";
            this.button_WOC2.TextColor = System.Drawing.Color.White;
            this.button_WOC2.UseVisualStyleBackColor = false;
            this.button_WOC2.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // btndetenre
            // 
            this.btndetenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btndetenre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btndetenre.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(194)))), ((int)(((byte)(181)))));
            this.btndetenre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btndetenre.FlatAppearance.BorderSize = 0;
            this.btndetenre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btndetenre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btndetenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetenre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetenre.Location = new System.Drawing.Point(375, 12);
            this.btndetenre.Name = "btndetenre";
            this.btndetenre.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btndetenre.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btndetenre.OnHoverTextColor = System.Drawing.Color.White;
            this.btndetenre.Size = new System.Drawing.Size(143, 53);
            this.btndetenre.TabIndex = 15;
            this.btndetenre.Text = "DETENER";
            this.btndetenre.TextColor = System.Drawing.Color.White;
            this.btndetenre.UseVisualStyleBackColor = false;
            this.btndetenre.Click += new System.EventHandler(this.btndetenre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimumSize = new System.Drawing.Size(1364, 736);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semaforo";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcxd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSemaforoOeste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSemaforoSur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSemaforoEste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSemaforo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFondo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox picBxSemaforo;
        private System.Windows.Forms.PictureBox picBxSemaforoEste;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBxSemaforoSur;
        private System.Windows.Forms.PictureBox picBxSemaforoOeste;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.PictureBox pcFondo;
        private System.Windows.Forms.PictureBox pcxd;
        private ePOSOne.btnProduct.Button_WOC btnpreventivas;
        private ePOSOne.btnProduct.Button_WOC btntick;
        private ePOSOne.btnProduct.Button_WOC btndetenre;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private System.Windows.Forms.Panel panel1;
    }
}

