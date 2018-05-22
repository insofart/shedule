namespace shedule
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Р.Киплинг \"Серые глаза - рассвет...\" (Перевод К. Симонова)",
            "Серые глаза - рассвет,",
            "Пароходная сирена,",
            "Дождь, разлука, серый след",
            "За винтом бегущей пены.",
            "",
            "Черные глаза - жара,",
            "В море сонных звезд скольженье,",
            "И у борта до утра",
            "Поцелуев отраженье.",
            "",
            "Синие глаза - луна,",
            "Вальса белое молчанье,",
            "Ежедневная стена",
            "Неизбежного прощанья.",
            "",
            "Карие глаза - песок,",
            "Осень, волчья степь, охота,",
            "Скачка, вся на волосок",
            "От паденья и полета.",
            "",
            "Нет, я не судья для них,",
            "Просто без суждений вздорных",
            "Я четырежды должник",
            "Синих, серых, карих, черных.",
            "",
            "Как четыре стороны",
            "Одного того же света,",
            "Я люблю - в том нет вины -",
            "Все четыре этих цвета."});
            this.listBox1.Location = new System.Drawing.Point(12, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 277);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 436);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

