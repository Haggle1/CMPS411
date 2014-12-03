using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace uFR_Coder_Simplest
{
    public partial class frmuFRCoderSimplest : Form
    {
        public frmuFRCoderSimplest()
        {
            InitializeComponent();
        }

        private UInt32 result;
        private Boolean CONN = false;
        private Boolean reader_stop = false,
                        thread_start = false,
                        functionOn = false;

        const byte DL_OK = 0,
                   KEY_INDEX = 0,
                   AUTH_MODE = 96,
                   RES_OK_LIGHT = 4,
                   RES_OK_SOUND = 0,
                   ERR_LIGHT = 2,
                   ERR_SOUND = 0;

        const byte FORMATSIGN = 32;

        const ushort MAX_BYTES = 752,
                     LINEAR_ADDRESS = 0;
        private string[] ERR_CODE = new string[180];

        void ERRORS_CODE(uint result, System.Windows.Forms.StatusStrip Status_bar)
        {
            ERR_CODE[0] = "DL_OK ";
            ERR_CODE[1] = "COMMUNICATION_ERROR ";
            ERR_CODE[3] = "READING_ERROR ";
            ERR_CODE[4] = "WRITING_ERROR ";
            ERR_CODE[6] = "MAX_ADDRESS_EXCEEDED ";
            ERR_CODE[7] = "MAX_KEY_INDEX_EXCEEDED ";
            ERR_CODE[8] = "NO_CARD ";
            ERR_CODE[10] = "FORBIDEN_DIRECT_WRITE_IN_SECTOR_TRAILER ";
            ERR_CODE[11] = "ADDRESSED_BLOCK_IS_NOT_SECTOR_TRAILER ";
            ERR_CODE[12] = "WRONG_ADDRESS_MODE ";
            ERR_CODE[13] = "WRONG_ACCESS_BITS_VALUES ";
            ERR_CODE[14] = "AUTH_ERROR ";
            ERR_CODE[15] = "PARAMETERS_ERROR ";
            ERR_CODE[80] = "COMMUNICATION_BREAK ";
            ERR_CODE[82] = "CAN_NOT_OPEN_READER ";
            ERR_CODE[84] = "READER_OPENING_ERROR ";
            ERR_CODE[85] = "READER_PORT_NOT_OPENED ";
            ERR_CODE[114] = "VALUE_BLOCK_INVALID ";
            ERR_CODE[113] = "BUFFER_SIZE_EXCEEDED ";
            ERR_CODE[115] = "VALUE_BLOCK_ADDR_INVALID ";
            ERR_CODE[116] = "VALUE_BLOCK_MANIPULATION_ERROR ";
            ERR_CODE[117] = "WRONG_UI_MODE";
            ERR_CODE[121] = "CAN_NOT_LOCK_DEVICE";
            ERR_CODE[122] = "CAN_NOT_UNLOCK_DEVICE";
            ERR_CODE[123] = "DEVICE_EEPROM_BUSY";
            ERR_CODE[160] = "HARDWARE_ERROR";
            ERR_CODE[161] = "HARDWARE_ERROR";
            Status_bar.Items[1].Text = "0x" + result.ToString("X2");
            Status_bar.Items[2].Text = ERR_CODE[result];

        }
        private void ReaderOff()
        {
            reader_stop = true;
        }
        private void ReaderOn()
        {
            reader_stop = false;
        }
        private void mnuExitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainThread()
        {
            thread_start = true;
            byte card_type = 0;
            ulong card_serial = 0;
            ulong reader_type = 0;
            if (!CONN)
            {
                if ((result = uFRCoder1x.ReaderOpen()) == DL_OK)
                {
                    pnlConnected.Text = "CONNECTED";
                    CONN = true;
                    ERRORS_CODE(result, stbConnected);
                }
                else
                {

                    pnlConnected.Text = "NOT CONNECTED";
                    txtCardSerial.Text = "";
                    ERRORS_CODE(result, stbConnected);
                }
            }

            if (CONN)
            {

                unsafe
                {
                    if ((result = uFRCoder1x.GetReaderType(&reader_type)) == DL_OK)
                    {
                        if ((result = uFRCoder1x.GetCardId(&card_type, &card_serial)) == DL_OK)
                        {
                            txtCardSerial.Text = "0x" + card_serial.ToString("X");
                            ERRORS_CODE(result, stbCardStatus);
                            
                        }
                        else
                        {
                            txtCardSerial.Text = "";
                            ERRORS_CODE(result, stbCardStatus);
                        }
                    }
                    else
                    {
                        uFRCoder1x.ReaderClose();
                        CONN = false;
                    }
                }

            }
            thread_start = false;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!reader_stop)
                MainThread();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            if (functionOn) return;
            functionOn = true;
            ReaderOff();
             if (thread_start)
            {
                ReaderOn();
                functionOn = false;
                return;
            }

                ushort linear_address = 0;
                ushort bytes_ret = 0;
                ushort data_length = MAX_BYTES;
                byte[] read_data = new byte[MAX_BYTES];
                unsafe
                {
                    fixed (byte* PData = read_data)
                        result = uFRCoder1x.LinearRead(PData, linear_address, data_length, &bytes_ret, AUTH_MODE, KEY_INDEX);

                }
                if (result == DL_OK)
                {

                    //txtReadData.Text = System.Text.Encoding.ASCII.GetString(read_data);
                
                    txtReadData.Text = System.Text.Encoding.UTF8.GetString(read_data);


                    //Where to send information of card to.
                    string URI = "http://localhost/Data.php";
                    //Parameters to send with card to submit to DB
                    string myParameters = "id=" + "&contex=" + txtReadData.Text + "&idcard=card";

                    using (WebClient wc = new WebClient())
                    {
                        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                        string HtmlResult = wc.UploadString(URI, myParameters);
                    }

                    
                    uFRCoder1x.ReaderUISignal(RES_OK_LIGHT, RES_OK_SOUND);
                    ERRORS_CODE(result, stbFunction_error);
                }
                else
                {
                    uFRCoder1x.ReaderUISignal(ERR_LIGHT, ERR_SOUND);
                    ERRORS_CODE(result, stbFunction_error);
                }
            
            ReaderOn();
            functionOn = false;
        }



    }
}
