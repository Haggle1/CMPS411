unit Mifare;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, LResources, Forms, Controls, Graphics, Dialogs,ufCoder1x,
  ComCtrls, StdCtrls, ExtCtrls, Menus;

type

  { TfrmMifare }

  TfrmMifare = class(TForm)
    btnLockReader: TButton;
    btnUnLockReader: TButton;
    lblReaderLockKey: TLabel;
    lblReaderLockKey1: TLabel;
    pgReaderLockUnlock: TPageControl;
    rbUnLockDecimal: TRadioButton;
    rbLockHex: TRadioButton;
    rbLockDecimal: TRadioButton;
    rbUnLockHex: TRadioButton;
    tabReaderLock: TTabSheet;
    tabReaderUnlock: TTabSheet;
    txtReaderType: TStaticText;
    lblReaderSerial: TLabel;
    mnuExitItem: TMenuItem;
    mnuMeni: TMainMenu;
    Timer: TTimer;
    txtReaderSerial: TStaticText;
    lblReaderType: TLabel;
    stbMifare: TStatusBar;

    procedure btnLockReaderClick(Sender: TObject);
    procedure btnUnLockReaderClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure mnuExitItemClick(Sender: TObject);
    procedure OnMyLockKeyPress(Sender: TObject; var Key: char);
    procedure OnMyUnLockKeyPress(Sender: TObject; var Key: char);
    procedure TimerTimer(Sender: TObject);
  private
    CONN:Boolean;
    reader_type:LongInt;
    reader_serial:LongInt;
    ERR_CODE:array[0..180] of string;
    res:DL_STATUS;
    reader_key:array of byte;
    edit_box:array[0..7] of TEdit;
    procedure CreateLockEditBox(height_edit, width_edit, left_edit,top_edit: Byte; name_edit: string; parent_edit: TWinControl);
    procedure CreateUnLockEditBox(height_edit, width_edit, left_edit,top_edit: Byte; name_edit: string; parent_edit: TWinControl);
  public
    { public declarations }
  end;

const
     ERR_LIGHT=1;
     ERR_SOUND=2;
     RES_OK_LIGHT=4;
     RES_OK_SOUND=4;
     STATBAR_ERR_CODE=1;
     STATBAR_ERR_EXPL=2;
var
  frmMifare: TfrmMifare;

implementation

{ TfrmMifare }

procedure TfrmMifare.FormCreate(Sender: TObject);
begin
     CONN:=false;
     ERR_CODE[0]:='DL_OK ';
     ERR_CODE[1]:='COMMUNICATION_ERROR ';
     ERR_CODE[80]:='COMMUNICATION_BREAK ';
     ERR_CODE[82]:='CAN_NOT_OPEN_READER ';
     ERR_CODE[84]:='READER_OPENING_ERROR ';
     ERR_CODE[85]:='READER_PORT_NOT_OPENED ';
     ERR_CODE[117]:='WRONG_UI_MODE';
     ERR_CODE[118]:='KEYS_LOCKED';
     ERR_CODE[119]:='KEYS_UNLOCKED';
     ERR_CODE[120]:='WRONG_PASSWORD';
     ERR_CODE[121]:='CAN_NOT_LOCK_DEVICE';
     ERR_CODE[122]:='CAN_NOT_UNLOCK_DEVICE';
     ERR_CODE[123]:='DEVICE_EEPROM_BUSY';
     ERR_CODE[160]:='HARDWARE_ERROR';
     ERR_CODE[161]:='HARDWARE_ERROR';

     CreateLockEditBox(24,30,110,38,'txtKeyLock', tabReaderLock);
     CreateUnLockEditBox(24,30,110,38,'txtKeyUnlock', tabReaderUnlock);
end;
procedure TfrmMifare.btnLockReaderClick(Sender: TObject);
var
  br:Byte;
  keys:array[0..7] of byte;
  PKeys:^Byte;
begin
try
  PKeys:=nil;
  case rbLockHex.Checked of
       true:begin
              for br:=0 to 7 do begin
                  keys[br]:=StrToInt(HexDisplayPrefix+(TEdit(FindComponent('txtKeyLock'+IntToStr(br+1)))).Text);
                  end;
              end;
       false:begin
                for br:=0 to 7 do begin

                  if  StrToInt(TEdit(FindComponent('txtKeyLock'+IntToStr(br+1))).Text)>255 then begin
                    MessageDlg('Wrong entry !'+#13#10+ 'You must enter the numeric value of less than 255',mtError,[mbOk],0);
                    TEdit(FindComponent('txtKeyLock'+IntToStr(br+1))).SetFocus;
                    Exit;
                  end
                  else

                  keys[br]:=StrToInt(TEdit(FindComponent('txtKeyLock'+IntToStr(br+1))).Text);
                  end;
             end;
  end;
  PKeys:=PByte(@keys);
  res:=ReaderKeysLock(PKeys);
  if res=DL_OK then begin
     ReaderUISignal(RES_OK_LIGHT,RES_OK_SOUND);
     MessageDlg('Reader locked!',mtInformation,[mbOK],0);
  end
  else
     begin
       ReaderUISignal(ERR_LIGHT,ERR_SOUND);
       MessageDlg(ERR_CODE[res],mtInformation,[mbOK],0);
     end;
except
 on Exception:EConvertError do
    MessageDlg('Wrong entry!'+#13#10+'Please enter the correct number in the field.',mtError,[mbOK],0);
end;
end;



procedure TfrmMifare.btnUnLockReaderClick(Sender: TObject);
var
  br:Byte;
  keys:array[0..7] of byte;
  PKeys:^Byte;
begin
  PKeys:=nil;
 try
  case rbUnLockHex.Checked of
       true:begin
              for br:=0 to 7 do begin
                  keys[br]:=StrToInt(HexDisplayPrefix+(TEdit(FindComponent('txtKeyUnLock'+IntToStr(br+1)))).Text);
                  end;
              end;
       false:begin
                for br:=0 to 7 do begin

                if  StrToInt(TEdit(FindComponent('txtKeyUnLock'+IntToStr(br+1))).Text)>255 then begin
                    MessageDlg('Wrong entry !'+#13#10+ 'You must enter the numeric value of less than 255',mtError,[mbOk],0);
                    TEdit(FindComponent('txtKeyUnLock'+IntToStr(br+1))).SetFocus;
                    Exit;
                end;
                  keys[br]:=StrToInt(TEdit(FindComponent('txtKeyUnLock'+IntToStr(br+1))).Text);
                  end;
             end;
  end;
  PKeys:=PByte(@keys);
  res:=ReaderKeysUnlock(PKeys);
  if res=DL_OK then begin
     ReaderUISignal(RES_OK_LIGHT,RES_OK_SOUND);
     MessageDlg('Reader Unlocked!',mtInformation,[mbOK],0);
  end
  else
     begin
       ReaderUISignal(ERR_LIGHT,ERR_SOUND);
       MessageDlg(ERR_CODE[res],mtInformation,[mbOK],0);
     end;

 Except
  on Exception:EConvertError do
    MessageDlg('Wrong entry!'+#13#10+'Please enter the correct number in the fields',mtError,[mbOK],0);
 end;
end;

procedure TfrmMifare.mnuExitItemClick(Sender: TObject);
begin
  Close;
end;

procedure TfrmMifare.OnMyLockKeyPress(Sender: TObject; var Key: char);
begin
    if (rbLockHex.Checked)  then
       begin
         if Length((Sender as TEdit).Text)=2 then
         begin
            if (ord(Key)=8) then Exit else Key:=#0;
         end;
         if (Key in['0'..'9']) or (Key in['a'..'f']) or (ord(Key)=8) then Exit else Key:=#0;
       end
       else
           if (Key in['0'..'9']) or (ord(Key)=8) then Exit else Key:=#0;
end;

procedure TfrmMifare.OnMyUnLockKeyPress(Sender: TObject; var Key: char);
begin
    if (rbUnLockHex.Checked)  then
       begin
         if Length((Sender as TEdit).Text)=2 then
         begin
            if (ord(Key)=8) then Exit else Key:=#0;
         end;
         if (Key in['0'..'9']) or (Key in['a'..'f']) or (ord(Key)=8) then Exit else Key:=#0;
       end
       else
           if (Key in['0'..'9']) or (ord(Key)=8) then Exit else Key:=#0;
end;

procedure TfrmMifare.TimerTimer(Sender: TObject);
begin
     if not CONN then
     begin
        res:=ReaderOpen();
        if res=DL_OK then
        begin
           CONN:=true;
           stbMifare.Panels[0].Text:='CONNECTED';
           stbMifare.Panels[STATBAR_ERR_CODE].Text:='$'+IntToHex(res,2);
           stbMifare.Panels[STATBAR_ERR_EXPL].Text:=ERR_CODE[res];
        end
        else
        begin
           txtReaderType.Caption:='';
           txtReaderSerial.Caption:='';
           stbMifare.Panels[0].Text:='NOT CONNECTED';
           stbMifare.Panels[STATBAR_ERR_CODE].Text:='$'+IntToHex(res,2);
           stbMifare.Panels[STATBAR_ERR_EXPL].Text:=ERR_CODE[res];

        end;
     end;
     if CONN then
        begin
           res:=GetReaderType(reader_type);
           if res=DL_OK then
              txtReaderType.Caption:='$'+IntToHex(reader_type,8)
           else
              begin
              CONN:=false;
              ReaderClose();
              end;
           res:=GetReaderSerialNumber(reader_serial);
           if res=DL_OK then
              txtReaderSerial.Caption:='$'+IntToHex(reader_serial,8);
        end;

end;

procedure TfrmMifare.CreateLockEditBox(height_edit, width_edit, left_edit,
  top_edit: Byte;name_edit:string;  parent_edit: TWinControl);
var
  br:Byte;
begin
  for br:=0 to 7 do begin
     edit_box[br]:=TEdit.Create(self);
     with edit_box[br] do begin
          Height:=height_edit;
          Width:=width_edit;
          Top:=top_edit;
          Left:=left_edit+(width_edit*br+1);
          MaxLength:=3;
          name:=name_edit+IntToStr(br+1);
          text:='';
          Font.Size:=10;
          Font.Style:=[fsBold];
          CharCase:=ecUppercase;
          Alignment:=taCenter;
          OnKeyPress:=@OnMyLockKeyPress;
          parent:=parent_edit;
     end;
  end;
end;

procedure TfrmMifare.CreateUnLockEditBox(height_edit, width_edit, left_edit,
  top_edit: Byte; name_edit: string; parent_edit: TWinControl);
var
  br:Byte;
begin
  for br:=0 to 7 do begin
     edit_box[br]:=TEdit.Create(self);
     with edit_box[br] do begin
          Height:=height_edit;
          Width:=width_edit;
          Top:=top_edit;
          Left:=left_edit+(width_edit*br+1);
          MaxLength:=3;
          name:=name_edit+IntToStr(br+1);
          text:='';
          Font.Size:=10;
          Font.Style:=[fsBold];
          CharCase:=ecUppercase;
          Alignment:=taCenter;
          OnKeyPress:=@OnMyUnLockKeyPress;
          parent:=parent_edit;
     end;
  end;

end;

initialization
  {$I Mifare.lrs}

end.

