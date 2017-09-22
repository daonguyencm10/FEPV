using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace Infrastructure
{
    [ProvideProperty("AllowKeyTab", typeof(Component))]
    public partial class KeyTab : Component, IExtenderProvider
    {
        public Keys NextK;
        public Keys PreviousK;
        Hashtable _hashTable = new Hashtable();
       

        #region Constructor
        public KeyTab()
        {
            InitializeComponent();
        }
        public KeyTab(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        #endregion

        #region ����AllowKeyTab
        public void SetAllowKeyTab(Component component, bool  Allow)
        {
            if (Allow)
            {
                if (_hashTable.Contains(component) != true)
                {
                    //MessageBox.Show(component.ToString());
                    _hashTable.Add(component, Allow);
                    Control currentC = (Control)component;
                    currentC.KeyDown += new KeyEventHandler(currentC_KeyDown);
                }
            }
            else
            {
                if (_hashTable.Contains(component) == true)
                {
                    _hashTable.Remove(component);
                }
            }
            
        }
        public bool  GetAllowKeyTab(Component component)
        {
            if (_hashTable.Contains(component))
            {
                return true;
            }
            return false;
        }
        #endregion

        
        /// <summary>
        /// �������Լ���
          /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        public bool GetKeyTab(Component component)
        {
            if (_hashTable.Contains(component))
            {
                return (bool)_hashTable[component];
            }

            return false;
        }
        private void currentC_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == this.NextK)
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == this.PreviousK)
            {
                SendKeys.Send("+{TAB}");//����shift+tab
            }
        }

        public bool CanExtend(object component)
        {
            //��������ͨ�ؼ����ų�Form����֧����չ 
            if (component is Control && !(component is Form))
            {
                return true;
            }

            return false;
        }


       
       
    }
}
