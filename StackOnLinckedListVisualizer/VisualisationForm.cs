using StackOnLinckedListVisualizer.Drawings;
using StackOnLinckedListVisualizer.Implementations;
using StackOnLinckedListVisualizer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace StackOnLinckedListVisualizer
{
    public partial class VisualisationForm : Form
    {
        private DrawStackList _draw;
        private StackOnLinkedListSettings _settings;
        private StackOnLinkedListAlgorithm _algorithm;

        public VisualisationForm()
        {
            InitializeComponent();

            _settings = new StackOnLinkedListSettings();
            _draw = new DrawStackList();
            _algorithm = new StackOnLinkedListAlgorithm();


            pictureBox.Invalidate();
            updateInfomations();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            string? topValue = _settings.DataCollection.Count > 0 ? _settings.DataCollection.First.Value.ToString() : null;

            _draw.DrawList(e.Graphics, pictureBox.ClientRectangle, _settings.DataCollection, topValue);
        }

        private void pushButton_Click(object sender, EventArgs e)
        {

            if (_settings == null || _algorithm == null) return;

            if (int.TryParse(textPushBox.Text, out int value))
            {
                _algorithm.Push(_settings, value);
                pictureBox.Invalidate();
                updateInfomations();
                textPushBox.Clear();
                AddLogEntry($"Push({value}) called", LogLevel.INFO);
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddLogEntry($"Push invalid Input", LogLevel.ERROR);
            }
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            if (_settings == null || _algorithm == null) return;
            int? tempNumber = _algorithm.Pop(_settings);
            if (tempNumber.HasValue)
            {
                MessageBox.Show($"Popped value: {tempNumber}", "Pop Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateInfomations();
                pictureBox.Invalidate();
                AddLogEntry($"Popped({tempNumber}) called", LogLevel.INFO);
            }
            else
            {
                MessageBox.Show("Cannot pop from empty stack.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddLogEntry("Cannot pop from empty stack", LogLevel.ERROR);
            }

        }

        private void buttonPeek_Click(object sender, EventArgs e)
        {
            if (_settings == null || _algorithm == null) return;
            int? tempNumber = _algorithm.Peek(_settings);
            if (tempNumber.HasValue)
            {
                MessageBox.Show($"Peeked value: {tempNumber}", "Peek Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox.Invalidate();
                AddLogEntry($"Peeked value: {tempNumber} called", LogLevel.INFO);
            }
            else
            {
                MessageBox.Show("Cannot peek from empty stack.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddLogEntry("Cannot peek from empty stack", LogLevel.ERROR);

            }

        }

        private void buttonIsEmpty_Click(object sender, EventArgs e)
        {
            if (_settings == null || _algorithm == null) return;
            bool tempIsempty = _algorithm.IsEmpty(_settings);
            if (tempIsempty)
            {
                MessageBox.Show($"Stack is empty.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox.Invalidate();
                AddLogEntry($"Stack is empty", LogLevel.INFO);
            }
            else
            {
                MessageBox.Show("Stack isn't empty", "Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddLogEntry($"Stack is empty", LogLevel.INFO);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (_settings == null || _algorithm == null) return;
            if (_algorithm.IsEmpty(_settings))
            {
                MessageBox.Show("Stack is already empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddLogEntry($"Stack is already empty", LogLevel.WARNING);
            }
            else
            {
                if (MessageBox.Show("Do you really want to clear the stack?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _algorithm.Clear(_settings);
                    pictureBox.Invalidate();
                    updateInfomations();
                    AddLogEntry($"Clear the stack", LogLevel.INFO);
                    return;
                }
                AddLogEntry($"Don't clear the stack", LogLevel.INFO);
            }
        }
        private void updateInfomations()
        {
            labelName.Text = $"Algorithm Name: {_settings.AlgorithmName}";
            labelDescription.Text = $"Description: {_settings.Description}";
            labelSize.Text = $"Size: {_settings.DataCollection.Count}";
            labelTop.Text = _settings.DataCollection.Count > 0
                ? $"Top: {_settings.DataCollection.First.Value}"
                : "Top: null";
            AddLogEntry($"Update groupBox infomations", LogLevel.INFO);
        }

        private void AddLogEntry(string message, LogLevel level)
        {
            if (richTextLogoBox == null) return;

            var color = level switch
            {
                LogLevel.ERROR => Color.Red,
                LogLevel.WARNING => Color.Orange,
                LogLevel.INFO => Color.Blue,
                _ => Color.Black
            };

            richTextLogoBox.SelectionColor = color;
            richTextLogoBox.AppendText($"[{DateTime.Now:HH:mm:ss}] [{level}] {message}\n");
            richTextLogoBox.ScrollToCaret();
        }


    }
}