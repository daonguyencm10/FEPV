using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace Infrastructure
{
 
    [ProvideProperty("NextControl", typeof(Component))]
    [ProvideProperty("PreviousControl", typeof(Component))]
    public partial class ControlFocus : Component, IExtenderProvider
    {
       
        Hashtable _hashTable = new Hashtable();
        Hashtable _previousHashTable = new Hashtable();

        
        public Keys NextK;
        public Keys PreviousK;

        public ControlFocus()
        {
            InitializeComponent();
           
        }

        public ControlFocus(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        
        public void SetNextControl(Component component, Control c)
        {
            if (_hashTable.Contains(component) != true)
            {
                //MessageBox.Show(component.ToString());
                _hashTable.Add(component, c);
                Control currentC = (Control)component;
                currentC.KeyDown += new KeyEventHandler(currentC_KeyDown);
            }
            else
            {
                _hashTable[component] = c;
            }
        }
        public Control GetNextControl(Component component)
        {
            if (_hashTable.Contains(component))
            {
                return (Control)_hashTable[component];
            }
            return null;
        }


        public void SetPreviousControl(Component component, Control c)
        {

           
            if (_previousHashTable.Contains(component) != true)
            {
               // MessageBox.Show(component.ToString());
                _previousHashTable.Add(component, c);
                Control currentC = (Control)component;
                currentC.KeyDown += new KeyEventHandler(currentC_KeyDown);
            }
            else
            {
                _previousHashTable[component] = c;
            }
        }

        public Control GetPreviousControl(Component component)
        {
            if (_previousHashTable.Contains(component))
            {
                return (Control)_previousHashTable[component];
            }
            return null;
        }

        /// <summary>
        /// Used to retrieve the MenuImage extender property value
        /// for a given <c>MenuItem</c> component instance.
        /// </summary>
        /// <param name="component">the menu item instance associated with the value</param>
        /// <returns>Returns the MenuImage index property value for the specified <c>MenuItem</c> component instance.</returns>
        public string GetControlFocus(Component component)
        {
            if (_hashTable.Contains(component))
            {
                return (string)_hashTable[component];
            }

            return null;
        }
        public bool CanExtend(object component)
        {
            // only support MenuItem objects that are not
            // top-level menus (default rendering for top-level
            // menus is fine - does not need extension
            if (component is Control && !(component is Form))
            {
                return true;
            }

            return false;
        }




        private void currentC_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == this.NextK)
            {
               
                SendKeys.Send("{TAB}");

                // Control nextControl = this.GetNextControl((Component)sender);
               // if (nextControl != null && nextControl.CanFocus)
               //     nextControl.Focus();
            }
            else if (e.KeyCode == this.PreviousK)
            {
                SendKeys.Send("+{TAB}");
              //  Control previousControl = this.GetPreviousControl((Component)sender);
              //  if (previousControl != null && previousControl.CanFocus)
              //      previousControl.Focus();
            }
        }

    }

       
}
