namespace JuegoDelAhorcado
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
            this.Iniciar = new System.Windows.Forms.Button();
            this.Resolver = new System.Windows.Forms.Button();
            this.PalabraSecreta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.teclado = new System.Windows.Forms.GroupBox();
            this.bZ = new System.Windows.Forms.Button();
            this.bY = new System.Windows.Forms.Button();
            this.bX = new System.Windows.Forms.Button();
            this.bW = new System.Windows.Forms.Button();
            this.bV = new System.Windows.Forms.Button();
            this.bU = new System.Windows.Forms.Button();
            this.bT = new System.Windows.Forms.Button();
            this.bS = new System.Windows.Forms.Button();
            this.bR = new System.Windows.Forms.Button();
            this.bQ = new System.Windows.Forms.Button();
            this.bP = new System.Windows.Forms.Button();
            this.bO = new System.Windows.Forms.Button();
            this.bnn = new System.Windows.Forms.Button();
            this.bN = new System.Windows.Forms.Button();
            this.bM = new System.Windows.Forms.Button();
            this.bL = new System.Windows.Forms.Button();
            this.bK = new System.Windows.Forms.Button();
            this.bJ = new System.Windows.Forms.Button();
            this.bI = new System.Windows.Forms.Button();
            this.bH = new System.Windows.Forms.Button();
            this.bG = new System.Windows.Forms.Button();
            this.bF = new System.Windows.Forms.Button();
            this.bE = new System.Windows.Forms.Button();
            this.bD = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bB = new System.Windows.Forms.Button();
            this.bA = new System.Windows.Forms.Button();
            this.Ahorcado = new System.Windows.Forms.PictureBox();
            this.vidas = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.teclado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ahorcado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidas)).BeginInit();
            this.SuspendLayout();
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(86, 30);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(326, 68);
            this.Iniciar.TabIndex = 0;
            this.Iniciar.Text = "Iniciar Juego";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // Resolver
            // 
            this.Resolver.Location = new System.Drawing.Point(86, 127);
            this.Resolver.Name = "Resolver";
            this.Resolver.Size = new System.Drawing.Size(325, 68);
            this.Resolver.TabIndex = 1;
            this.Resolver.Text = "Resolver";
            this.Resolver.UseVisualStyleBackColor = true;
            this.Resolver.Click += new System.EventHandler(this.Resolver_Click);
            // 
            // PalabraSecreta
            // 
            this.PalabraSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalabraSecreta.Location = new System.Drawing.Point(44, 30);
            this.PalabraSecreta.Name = "PalabraSecreta";
            this.PalabraSecreta.Size = new System.Drawing.Size(421, 68);
            this.PalabraSecreta.TabIndex = 2;
            this.PalabraSecreta.TextChanged += new System.EventHandler(this.PalabraSecreta_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Iniciar);
            this.groupBox1.Controls.Add(this.Resolver);
            this.groupBox1.Location = new System.Drawing.Point(31, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 219);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PalabraSecreta);
            this.groupBox2.Location = new System.Drawing.Point(31, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Palabra secreta";
            // 
            // teclado
            // 
            this.teclado.Controls.Add(this.bZ);
            this.teclado.Controls.Add(this.bY);
            this.teclado.Controls.Add(this.bX);
            this.teclado.Controls.Add(this.bW);
            this.teclado.Controls.Add(this.bV);
            this.teclado.Controls.Add(this.bU);
            this.teclado.Controls.Add(this.bT);
            this.teclado.Controls.Add(this.bS);
            this.teclado.Controls.Add(this.bR);
            this.teclado.Controls.Add(this.bQ);
            this.teclado.Controls.Add(this.bP);
            this.teclado.Controls.Add(this.bO);
            this.teclado.Controls.Add(this.bnn);
            this.teclado.Controls.Add(this.bN);
            this.teclado.Controls.Add(this.bM);
            this.teclado.Controls.Add(this.bL);
            this.teclado.Controls.Add(this.bK);
            this.teclado.Controls.Add(this.bJ);
            this.teclado.Controls.Add(this.bI);
            this.teclado.Controls.Add(this.bH);
            this.teclado.Controls.Add(this.bG);
            this.teclado.Controls.Add(this.bF);
            this.teclado.Controls.Add(this.bE);
            this.teclado.Controls.Add(this.bD);
            this.teclado.Controls.Add(this.bC);
            this.teclado.Controls.Add(this.bB);
            this.teclado.Controls.Add(this.bA);
            this.teclado.Location = new System.Drawing.Point(31, 498);
            this.teclado.Name = "teclado";
            this.teclado.Size = new System.Drawing.Size(522, 406);
            this.teclado.TabIndex = 6;
            this.teclado.TabStop = false;
            this.teclado.Text = "Teclado";
            // 
            // bZ
            // 
            this.bZ.Location = new System.Drawing.Point(171, 314);
            this.bZ.Name = "bZ";
            this.bZ.Size = new System.Drawing.Size(69, 65);
            this.bZ.TabIndex = 26;
            this.bZ.Text = "Z";
            this.bZ.UseVisualStyleBackColor = true;
            this.bZ.Click += new System.EventHandler(this.bZ_Click);
            // 
            // bY
            // 
            this.bY.Location = new System.Drawing.Point(91, 314);
            this.bY.Name = "bY";
            this.bY.Size = new System.Drawing.Size(69, 65);
            this.bY.TabIndex = 25;
            this.bY.Text = "Y";
            this.bY.UseVisualStyleBackColor = true;
            this.bY.Click += new System.EventHandler(this.bY_Click);
            // 
            // bX
            // 
            this.bX.Location = new System.Drawing.Point(16, 315);
            this.bX.Name = "bX";
            this.bX.Size = new System.Drawing.Size(69, 65);
            this.bX.TabIndex = 24;
            this.bX.Text = "X";
            this.bX.UseVisualStyleBackColor = true;
            this.bX.Click += new System.EventHandler(this.bX_Click);
            // 
            // bW
            // 
            this.bW.Location = new System.Drawing.Point(396, 243);
            this.bW.Name = "bW";
            this.bW.Size = new System.Drawing.Size(69, 65);
            this.bW.TabIndex = 23;
            this.bW.Text = "W";
            this.bW.UseVisualStyleBackColor = true;
            this.bW.Click += new System.EventHandler(this.bW_Click);
            // 
            // bV
            // 
            this.bV.Location = new System.Drawing.Point(321, 244);
            this.bV.Name = "bV";
            this.bV.Size = new System.Drawing.Size(69, 65);
            this.bV.TabIndex = 22;
            this.bV.Text = "V";
            this.bV.UseVisualStyleBackColor = true;
            this.bV.Click += new System.EventHandler(this.bV_Click);
            // 
            // bU
            // 
            this.bU.Location = new System.Drawing.Point(246, 244);
            this.bU.Name = "bU";
            this.bU.Size = new System.Drawing.Size(69, 65);
            this.bU.TabIndex = 21;
            this.bU.Text = "U";
            this.bU.UseVisualStyleBackColor = true;
            this.bU.Click += new System.EventHandler(this.bU_Click);
            // 
            // bT
            // 
            this.bT.Location = new System.Drawing.Point(171, 243);
            this.bT.Name = "bT";
            this.bT.Size = new System.Drawing.Size(69, 65);
            this.bT.TabIndex = 20;
            this.bT.Text = "T";
            this.bT.UseVisualStyleBackColor = true;
            this.bT.Click += new System.EventHandler(this.bT_Click);
            // 
            // bS
            // 
            this.bS.Location = new System.Drawing.Point(91, 243);
            this.bS.Name = "bS";
            this.bS.Size = new System.Drawing.Size(69, 65);
            this.bS.TabIndex = 19;
            this.bS.Text = "S";
            this.bS.UseVisualStyleBackColor = true;
            this.bS.Click += new System.EventHandler(this.bS_Click);
            // 
            // bR
            // 
            this.bR.Location = new System.Drawing.Point(16, 244);
            this.bR.Name = "bR";
            this.bR.Size = new System.Drawing.Size(69, 65);
            this.bR.TabIndex = 18;
            this.bR.Text = "R";
            this.bR.UseVisualStyleBackColor = true;
            this.bR.Click += new System.EventHandler(this.bR_Click);
            // 
            // bQ
            // 
            this.bQ.Location = new System.Drawing.Point(396, 172);
            this.bQ.Name = "bQ";
            this.bQ.Size = new System.Drawing.Size(69, 65);
            this.bQ.TabIndex = 17;
            this.bQ.Text = "Q";
            this.bQ.UseVisualStyleBackColor = true;
            this.bQ.Click += new System.EventHandler(this.bQ_Click);
            // 
            // bP
            // 
            this.bP.Location = new System.Drawing.Point(321, 173);
            this.bP.Name = "bP";
            this.bP.Size = new System.Drawing.Size(69, 65);
            this.bP.TabIndex = 16;
            this.bP.Text = "P";
            this.bP.UseVisualStyleBackColor = true;
            this.bP.Click += new System.EventHandler(this.bP_Click);
            // 
            // bO
            // 
            this.bO.Location = new System.Drawing.Point(246, 173);
            this.bO.Name = "bO";
            this.bO.Size = new System.Drawing.Size(69, 65);
            this.bO.TabIndex = 15;
            this.bO.Text = "O";
            this.bO.UseVisualStyleBackColor = true;
            this.bO.Click += new System.EventHandler(this.bO_Click);
            // 
            // bnn
            // 
            this.bnn.Location = new System.Drawing.Point(171, 172);
            this.bnn.Name = "bnn";
            this.bnn.Size = new System.Drawing.Size(69, 65);
            this.bnn.TabIndex = 14;
            this.bnn.Text = "Ñ";
            this.bnn.UseVisualStyleBackColor = true;
            this.bnn.Click += new System.EventHandler(this.bnn_Click);
            // 
            // bN
            // 
            this.bN.Location = new System.Drawing.Point(91, 172);
            this.bN.Name = "bN";
            this.bN.Size = new System.Drawing.Size(69, 65);
            this.bN.TabIndex = 13;
            this.bN.Text = "N";
            this.bN.UseVisualStyleBackColor = true;
            this.bN.Click += new System.EventHandler(this.bN_Click);
            // 
            // bM
            // 
            this.bM.Location = new System.Drawing.Point(16, 173);
            this.bM.Name = "bM";
            this.bM.Size = new System.Drawing.Size(69, 65);
            this.bM.TabIndex = 12;
            this.bM.Text = "M";
            this.bM.UseVisualStyleBackColor = true;
            this.bM.Click += new System.EventHandler(this.bM_Click);
            // 
            // bL
            // 
            this.bL.Location = new System.Drawing.Point(396, 101);
            this.bL.Name = "bL";
            this.bL.Size = new System.Drawing.Size(69, 65);
            this.bL.TabIndex = 11;
            this.bL.Text = "L";
            this.bL.UseVisualStyleBackColor = true;
            this.bL.Click += new System.EventHandler(this.bL_Click);
            // 
            // bK
            // 
            this.bK.Location = new System.Drawing.Point(321, 102);
            this.bK.Name = "bK";
            this.bK.Size = new System.Drawing.Size(69, 65);
            this.bK.TabIndex = 10;
            this.bK.Text = "K";
            this.bK.UseVisualStyleBackColor = true;
            this.bK.Click += new System.EventHandler(this.bK_Click);
            // 
            // bJ
            // 
            this.bJ.Location = new System.Drawing.Point(246, 102);
            this.bJ.Name = "bJ";
            this.bJ.Size = new System.Drawing.Size(69, 65);
            this.bJ.TabIndex = 9;
            this.bJ.Text = "J";
            this.bJ.UseVisualStyleBackColor = true;
            this.bJ.Click += new System.EventHandler(this.bJ_Click);
            // 
            // bI
            // 
            this.bI.Location = new System.Drawing.Point(171, 101);
            this.bI.Name = "bI";
            this.bI.Size = new System.Drawing.Size(69, 65);
            this.bI.TabIndex = 8;
            this.bI.Text = "I";
            this.bI.UseVisualStyleBackColor = true;
            this.bI.Click += new System.EventHandler(this.bI_Click);
            // 
            // bH
            // 
            this.bH.Location = new System.Drawing.Point(91, 101);
            this.bH.Name = "bH";
            this.bH.Size = new System.Drawing.Size(69, 65);
            this.bH.TabIndex = 7;
            this.bH.Text = "H";
            this.bH.UseVisualStyleBackColor = true;
            this.bH.Click += new System.EventHandler(this.bH_Click);
            // 
            // bG
            // 
            this.bG.Location = new System.Drawing.Point(16, 102);
            this.bG.Name = "bG";
            this.bG.Size = new System.Drawing.Size(69, 65);
            this.bG.TabIndex = 6;
            this.bG.Text = "G";
            this.bG.UseVisualStyleBackColor = true;
            this.bG.Click += new System.EventHandler(this.bG_Click);
            // 
            // bF
            // 
            this.bF.Location = new System.Drawing.Point(396, 30);
            this.bF.Name = "bF";
            this.bF.Size = new System.Drawing.Size(69, 65);
            this.bF.TabIndex = 5;
            this.bF.Text = "F";
            this.bF.UseVisualStyleBackColor = true;
            this.bF.Click += new System.EventHandler(this.bF_Click);
            // 
            // bE
            // 
            this.bE.Location = new System.Drawing.Point(321, 31);
            this.bE.Name = "bE";
            this.bE.Size = new System.Drawing.Size(69, 65);
            this.bE.TabIndex = 4;
            this.bE.Text = "E";
            this.bE.UseVisualStyleBackColor = true;
            this.bE.Click += new System.EventHandler(this.bE_Click);
            // 
            // bD
            // 
            this.bD.Location = new System.Drawing.Point(246, 31);
            this.bD.Name = "bD";
            this.bD.Size = new System.Drawing.Size(69, 65);
            this.bD.TabIndex = 3;
            this.bD.Text = "D";
            this.bD.UseVisualStyleBackColor = true;
            this.bD.Click += new System.EventHandler(this.bD_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(171, 30);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(69, 65);
            this.bC.TabIndex = 2;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bB
            // 
            this.bB.Location = new System.Drawing.Point(91, 30);
            this.bB.Name = "bB";
            this.bB.Size = new System.Drawing.Size(69, 65);
            this.bB.TabIndex = 1;
            this.bB.Text = "B";
            this.bB.UseVisualStyleBackColor = true;
            this.bB.Click += new System.EventHandler(this.bB_Click);
            // 
            // bA
            // 
            this.bA.Location = new System.Drawing.Point(16, 31);
            this.bA.Name = "bA";
            this.bA.Size = new System.Drawing.Size(69, 65);
            this.bA.TabIndex = 0;
            this.bA.Text = "A";
            this.bA.UseVisualStyleBackColor = true;
            this.bA.Click += new System.EventHandler(this.bA_Click);
            // 
            // Ahorcado
            // 
            this.Ahorcado.Image = global::JuegoDelAhorcado.Properties.Resources._0;
            this.Ahorcado.Location = new System.Drawing.Point(586, 34);
            this.Ahorcado.Name = "Ahorcado";
            this.Ahorcado.Size = new System.Drawing.Size(381, 870);
            this.Ahorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ahorcado.TabIndex = 0;
            this.Ahorcado.TabStop = false;
            // 
            // vidas
            // 
            this.vidas.Image = global::JuegoDelAhorcado.Properties.Resources._0B;
            this.vidas.Location = new System.Drawing.Point(31, 268);
            this.vidas.Name = "vidas";
            this.vidas.Size = new System.Drawing.Size(522, 71);
            this.vidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vidas.TabIndex = 5;
            this.vidas.TabStop = false;
            this.vidas.Click += new System.EventHandler(this.vidas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(998, 1118);
            this.Controls.Add(this.Ahorcado);
            this.Controls.Add(this.teclado);
            this.Controls.Add(this.vidas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego del ahorcado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.teclado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ahorcado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Button Resolver;
        private System.Windows.Forms.TextBox PalabraSecreta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox vidas;
        private System.Windows.Forms.GroupBox teclado;
        private System.Windows.Forms.Button bW;
        private System.Windows.Forms.Button bV;
        private System.Windows.Forms.Button bU;
        private System.Windows.Forms.Button bT;
        private System.Windows.Forms.Button bS;
        private System.Windows.Forms.Button bR;
        private System.Windows.Forms.Button bQ;
        private System.Windows.Forms.Button bP;
        private System.Windows.Forms.Button bO;
        private System.Windows.Forms.Button bnn;
        private System.Windows.Forms.Button bN;
        private System.Windows.Forms.Button bM;
        private System.Windows.Forms.Button bL;
        private System.Windows.Forms.Button bK;
        private System.Windows.Forms.Button bJ;
        private System.Windows.Forms.Button bI;
        private System.Windows.Forms.Button bH;
        private System.Windows.Forms.Button bG;
        private System.Windows.Forms.Button bF;
        private System.Windows.Forms.Button bE;
        private System.Windows.Forms.Button bD;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bB;
        private System.Windows.Forms.Button bA;
        private System.Windows.Forms.Button bZ;
        private System.Windows.Forms.Button bY;
        private System.Windows.Forms.Button bX;
        private System.Windows.Forms.PictureBox Ahorcado;
    }
}

