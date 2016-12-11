using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuMoney
{
    class KiwoomCode
    {
        private const int OP_ERR_NONE = 0;
        private const int OP_ERR_FAIL = -10;
        private const int OP_ERR_LOGIN = -100;
        private const int OP_ERR_CONNECT = -101;
        private const int OP_ERR_VERSION = -102;
        private const int OP_ERR_FIREWALL = -103;
        private const int OP_ERR_MEMORY = -104;
        private const int OP_ERR_INPUT = -105;
        private const int OP_ERR_SOCKET_CLOSED = -106;
        private const int OP_ERR_SIZE_OVERFLOW = -200;
        private const int OP_ERR_RQ_STRUCT_FAIL = -201;
        private const int OP_ERR_RQ_STRING_FAIL = -202;
        private const int OP_ERR_NO_DATA = -203;
        private const int OP_ERR_OVER_MAX_DATA = -204;
        private const int OP_ERR_DATA_RCV_FAIL = -205;
        private const int OP_ERR_OVER_MAX_FID = -206;
        private const int OP_ERR_REAL_CANCEL = -207;
        private const int OP_ERR_ORD_WRONG_INPUT = -300;
        private const int OP_ERR_ORD_WRONG_ACCTNO = -301;
        private const int OP_ERR_OTHER_ACC_USE = -302;
        private const int OP_ERR_MIS_2BILL_EXC = -303;
        private const int OP_ERR_MIS_5BILL_EXC = -304;
        private const int OP_ERR_MIS_1PER_EXC = -305;
        private const int OP_ERR_MIS_3PER_EXC = -306;
        private const int OP_ERR_SEND_FAIL = -307;
        private const int OP_ERR_ORD_OVERFLOW = -308;
        private const int OP_ERR_MIS_300CNT_EXC = -309;
        private const int OP_ERR_MIS_500CNT_EXC = -310;
        private const int OP_ERR_ORD_WRONG_ACCTINFO = -340;
        private const int OP_ERR_ORD_SYMCODE_EMPTY = -500;

        public string getErrorMsgString(int nError)
        {
            string str = "";

            switch (nError)
            {
                case OP_ERR_NONE:
                    str += "Success";
                    break;
                case OP_ERR_FAIL:
                    str += "Fail Error";
                    break;
                case OP_ERR_LOGIN:
                    str += "Login Error";
                    break;
                case OP_ERR_CONNECT:
                    str += "Connection Error";
                    break;
                case OP_ERR_VERSION:
                    str += "Veryfying version Error";
                    break;
                case OP_ERR_FIREWALL:
                    str += "Rirewall Error";
                    break;
                case OP_ERR_MEMORY:
                    str += "Memory protection Error";
                    break;
                case OP_ERR_INPUT:
                    str += "Input argument Error";
                    break;
                case OP_ERR_SOCKET_CLOSED:
                    str += "Socket closed Error";
                    break;
                case OP_ERR_SIZE_OVERFLOW:
                    str += "Size overflow Error";
                    break;
                case OP_ERR_RQ_STRUCT_FAIL:
                    str += "Request Structure Error";
                    break;
                case OP_ERR_RQ_STRING_FAIL:
                    str += "Request String Error";
                    break;
                case OP_ERR_NO_DATA:
                    str += "No Data Error";
                    break;
                case OP_ERR_OVER_MAX_DATA:
                    str += "Over Max Data Num Error";
                    break;
                case OP_ERR_DATA_RCV_FAIL:
                    str += "Data receivein Fail Error";
                    break;
                case OP_ERR_OVER_MAX_FID:
                    str += "Over Max Fid Error";
                    break;
                case OP_ERR_REAL_CANCEL:
                    str += "Real Cancel Error";
                    break;
                case OP_ERR_ORD_WRONG_INPUT:
                    str += "Wrong Order Error";
                    break;
                case OP_ERR_ORD_WRONG_ACCTNO:
                    str += "Wrong Account number Error";
                    break;
                case OP_ERR_OTHER_ACC_USE:
                    str += "Other account Error";
                    break;
                case OP_ERR_MIS_2BILL_EXC:
                    str += "Miss 2 Bills Error";
                    break;
                case OP_ERR_MIS_5BILL_EXC:
                    str += "Miss 5 Bills Error";
                    break;
                case OP_ERR_MIS_1PER_EXC:
                    str += "Miss 1 PER Error";
                    break;
                case OP_ERR_MIS_3PER_EXC:
                    str += "Miss 3 PERs Error";
                    break;
                case OP_ERR_SEND_FAIL:
                    str += "Send Fail Error";
                    break;
                case OP_ERR_ORD_OVERFLOW:
                    str += "Order overflow Error";
                    break;
                case OP_ERR_MIS_300CNT_EXC:
                    str += "Order Miss 300 counts Error";
                    break;
                case OP_ERR_MIS_500CNT_EXC:
                    str += "Order Miss 500 counts Error";
                    break;
                case OP_ERR_ORD_WRONG_ACCTINFO:
                    str += "Order wrond order account Error";
                    break;
                case OP_ERR_ORD_SYMCODE_EMPTY:
                    str += "Order system code information Error";
                    break;
                default :
                    str += "Undifined Error";
                    break;
                
            }

            return str;
        }
    }
}
