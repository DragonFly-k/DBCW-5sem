@echo off
echo Automatic Copy Oracle
echo -----------------------
RMAN target sys/orcl @C:\Users\Kate\Desktop\restore.rman;
pause;