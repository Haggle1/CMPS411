program projectMifare;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Interfaces, // this includes the LCL widgetset
  Forms, Mifare, LResources
  { you can add units after this };

{$IFDEF WINDOWS}{$R projectMifare.rc}{$ENDIF}

begin
  Application.Title:=' uFR Locker';
  {$I projectMifare.lrs}
  Application.Initialize;
  Application.CreateForm(TfrmMifare, frmMifare);
  Application.Run;
end.

