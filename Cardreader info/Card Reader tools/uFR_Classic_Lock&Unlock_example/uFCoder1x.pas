unit ufCoder1x;
interface
const
  MIFARE_CLASSIC_1k = $08;
const
  MF1ICS50 = $08;
const
  SLE66R35 = $88;
const
  MIFARE_CLASSIC_4k = $18;
const
  MF1ICS70 = $18;
const
  MIFARE_CLASSIC_MINI = $09;
const
  MF1ICS20 = $09;
const
  MIFARE_AUTHENT1A = $60;
  MIFARE_AUTHENT1B = $61;
  DL_OK=0;
type
  DL_STATUS = LongInt;



function ReaderOpen: DL_STATUS stdcall;
function ReaderClose: DL_STATUS stdcall;
function GetReaderType(var lpulReaderType: LongInt): DL_STATUS stdcall;
function GetReaderSerialNumber(var lpulSerialNumber: LongInt): DL_STATUS  stdcall ;
function ReaderUISignal(light_signal_mode: Byte;beep_signal_mode: Byte): DL_STATUS  stdcall;
function ReaderKeysLock(const bPassword:PByte):DL_STATUS stdcall;
function ReaderKeysUnlock(const bPassword:PByte):DL_STATUS stdcall;



implementation

function ReaderOpen:DL_STATUS;stdcall;external'uFCoder1x.dll';
function ReaderClose:DL_STATUS;stdcall; external 'uFCoder1x.dll';

function GetReaderType(var lpulReaderType: LongInt):DL_STATUS;stdcall; external  'uFCoder1x.dll';
function GetReaderSerialNumber(var lpulSerialNumber: LongInt):DL_STATUS;stdcall; external 'uFCoder1x.dll';
function ReaderUISignal(light_signal_mode: Byte;beep_signal_mode: Byte):DL_STATUS;stdcall; external 'uFCoder1x.dll';


function ReaderKeysLock(const bPassword:PByte):DL_STATUS stdcall;external 'ufCoder1x.dll';
function ReaderKeysUnlock(const bPassword:PByte):DL_STATUS stdcall;external 'ufCoder1x.dll';



end.
