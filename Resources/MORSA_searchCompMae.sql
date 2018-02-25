-- criar procedimento para obter companhias Mae de satelite
create proc MORSA.pr_satCompMae (@satID varchar(11), @comp varchar(200) OUTPUT)
as
begin tran
	select @comp = COALESCE(@comp + char(13),'')+ companhia
	from MORSA.satelite_companhiasMae where satelite=@satID
commit tran
go

--criar procedimento para obter companhias mae de estação espacial
create proc MORSA.pr_eeCompMae (@eeID varchar(11), @comp varchar(200) OUTPUT)	
as
begin tran
	select @comp = COALESCE(@comp + char(13),'')+ nif
	from MORSA.estacaoEspacial join MORSA.companhiaMae on id=estacaoEspac  where id=@eeID
commit tran