alter session set "_ORACLE_SCRIPT"=true; 
create user SED identified by Ks7631738;
grant dba to SED;
grant execute on sys.dbms_crypto to sed;