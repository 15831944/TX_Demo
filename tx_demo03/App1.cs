using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using Autodesk.AutoCAD.Runtime;



namespace TX_TOOLBOX
{

    public class MyApp : IExtensionApplication
    {

        public MyApp()
        {
            //=========�ж�ϵͳʱ��==============================
            if (WupiEngine.Wupi.CheckLicense(1) == false)
            {
                System.Windows.Forms.MessageBox.Show("û���ҵ������!", "License Error VAEntity",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new System.Exception("");
            }

            if (DateTime.Now.Year >= 2018)
            {
                throw new System.Exception("��ģ���޷�ʹ�ã��빺���������ϵ����֧�֡�");
            }
            //=========�ж�ϵͳʱ��==============================
        }

        public void Initialize()
        {
            if (WupiEngine.Wupi.CheckLicense(1) == false)
            {
                System.Windows.Forms.MessageBox.Show("û���ҵ������!", "License Error VAEntity",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new System.Exception("");
            }

            //=========�ж�ϵͳʱ��==============================
            if (DateTime.Now.Year >= 2018)
            {
                throw new System.Exception("��ģ���޷�ʹ�ã��빺���������ϵ����֧�֡�");
            }
            //=========�ж�ϵͳʱ��==============================


            String curfile = System.Reflection.Assembly.GetExecutingAssembly().Location;
            String curDirectory = Path.GetDirectoryName(curfile);
            AppDomain.CurrentDomain.AppendPrivatePath(curDirectory);

            //=========�ṩ�����Ϣ==============================
            MessageLines.WriteErrorMessageToAcad("\n�����ļ�" + curfile);
            //=========�ṩ�����Ϣ==============================
        }

        public void Terminate()
        {
        }
    }
}

