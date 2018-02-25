create proc MORSA.pr_addAstro @astroID as varchar(11), @astroTipo as varchar(20), @astroSistema as varchar(20), @astroGalaxia as varchar(20)
as
begin
begin tran
	begin try
		insert MORSA.astro (id, tipo, sistema, galaxia)
  	values (@astroID, @astroTipo, @astroSistema, @astroGalaxia)
    commit tran
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_updAstro @astroID as varchar(11), @astroTipo as varchar(20), @astroSistema as varchar(20), @astroGalaxia as varchar(20)
as
begin
begin tran
	begin try
		update MORSA.astro
    set id = @astroID, tipo = @astroTipo, sistema = @astroSistema, galaxia = @astroGalaxia
    where MORSA.astro.id = @astroID
    commit tran
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_delAstro @astroID as varchar(11)
as
begin
begin tran
	begin try
		delete MORSA.astro where MORSA.astro.id=@AstroID
    commit tran
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_addCompanhia @compNome as varchar(35), @compNIF as char(9), @compTelef as char(9), @compEnder as varchar(40), 
	@compCodPos as char(8), @compSede as varchar(20)
as
begin
	begin tran
	begin try
  	INSERT MORSA.companhia (nome, nif, telef, ender, codPos, sede) VALUES (@compNome, @compNIF, @compTelef, @compEnder, @compCodPos, @compSede)
    commit tran
  end try
  begin catch
  	rollback tran
  end catch
end

create proc MORSA.pr_updCompanhia @compNome as varchar(35), @compNIF as char(9), @compTelef as char(9), @compEnder as varchar(40), 
	@compCodPos as char(8), @compSede as varchar(20)
as
begin
begin tran
begin try
	update MORSA.companhia set nome = @compNome, nif = @compNIF, telef = @compEnder, ender = @compTelef, codPos = @compCodPos, sede = @compSede 
  	where MORSA.companhia.nif = @compNIF
    commit tran
end try
begin catch
	rollback tran
end catch
end

create proc MORSA.pr_delCompanhia @compNIF as char(9)
as
begin
begin tran
begin try
	delete MORSA.companhia where nif = @compNIF
  commit tran
end try
begin catch
	rollback tran
end catch
end

create proc MORSA.pr_addSatelite @satID as varchar(11), @satName as varchar(35), @satService as varchar(20), @paisOrgan as varchar(20), @compLog as char(9),
	@compMae as char(9), @lancam as varchar(11), @apoastro as varchar(10), @periastro as varchar(10), @inclin as varchar(7), 
	@periodo as varchar(15), @astro as varchar(11), @satStatus as varchar(9)
as
begin
begin tran
	begin try
		insert into MORSA.orbita values (@satID, @apoastro, @periastro, @inclin, @periodo, @astro);
		insert into MORSA.satelite values (@satID, @satName, @satService, @paisOrgan, @compLog, @lancam);
		insert into MORSA.satelite_status values (@satID, @satStatus);
		if NOT EXISTS(select * from MORSA.companhiaMae where nif = @compMae)
			insert into MORSA.companhiaMae values (@compMae,null);
		insert into MORSA.satelite_companhiasMae values(@satID, @compMae);
		commit tran
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_updSatelite @satID as varchar(11), @satName as varchar(35), @satService as varchar(20), @paisOrgan as varchar(20), @compLog as char(9), @lancam as varchar(11)
as
begin
begin tran
	begin try
		update MORSA.satelite
    set id = @satID, nome = @satName, servico = @satService, paisOrgan = @paisOrgan, compLog = @compLog, lancam = @lancam
    where id = @satID
    commit tran
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_delSatelite @satID as varchar(11)
as
begin
begin tran
	begin try
		delete from MORSA.satelite_companhiasMae where MORSA.satelite_companhiasMae.satelite = @satID
		delete from MORSA.satelite_status where MORSA.satelite_status.id = @satID;
		delete from MORSA.satelite where MORSA.satelite.id = @satID; 
		delete from MORSA.orbita where MORSA.orbita.id = @satID;
		commit tran
	end try
	begin catch
		rollback tran
	end catch
end


create proc MORSA.pr_addEE @eeID as varchar(11), @eeName as varchar(35), @paisOrg as varchar(30), @compLog as char(9),
	@status as varchar(9), @apoastro as varchar(10), @periastro as varchar(10), @inclin as varchar(7), 
	@periodo as varchar(15), @astro as varchar(11), @compMae as char(9)
as
begin
begin tran
begin try
	insert into MORSA.orbita values (@eeID, @apoastro, @periastro, @inclin, @periodo, @astro);
	insert into MORSA.estacaoEspacial values (@eeID, @eeName, @paisOrg, @compLog);
	insert into MORSA.estacaoEspacial_status values (@eeID, @status);
	if Exists(select * from MORSA.companhiaMae where MORSA.companhiaMae.nif = @compMae)
		update MORSA.companhiaMae set estacaoEspac = @eeID where MORSA.companhiaMae.nif = @compMae; 
	else
		insert into MORSA.companhiaMae values (@compMae, @eeID);
commit tran
end try
begin catch
	rollback tran
end catch
end

create proc MORSA.pr_updEE @eeID as varchar(11), @eeName as varchar(35), @paisOrg as varchar(30), @compLog as char(9), @status as varchar(9)
as
begin
begin tran
	begin try
		update MORSA.estacaoEspacial
    set id = @eeID, nome = @eeName, paisOrgan = @paisOrg, compLog = @compLog
    where id = @eeID
		update MORSA.estacaoEspacial_status set MORSA.estacaoEspacial_status.status = @status where id = @eeID
    commit tran
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_delEE @eeID as varchar(11)
as
begin
begin tran
begin try
	declare @compNif char(9);
	set @compNif = (select nif from MORSA.companhiaMae where MORSA.companhiaMae.estacaoEspac = @eeID);
	if Exists(select * from MORSA.satelite_companhiasMae where MORSA.satelite_companhiasMae.companhia = @compNif)
		update MORSA.companhiaMae set estacaoEspac = null where nif = @compNif;
	else
		delete from MORSA.companhiaMae where estacaoEspac = @eeID;
	
	delete from MORSA.estacaoEspacial_status where MORSA.estacaoEspacial_status.id = @eeID;
	delete from MORSA.estacaoEspacial where MORSA.estacaoEspacial.id = @eeID;
	delete from MORSA.orbita where MORSA.orbita.id = @eeID;
	commit tran
end try
begin catch
	rollback tran
end catch
end

create proc MORSA.pr_addMEE @meeID as varchar(11), @meeNome as varchar(35), @meeTipo as varchar(20), @meeCompLog as char(9), @meeLanc as varchar(11), @meeEE as varchar(11)
as
begin
begin tran
	begin try
		insert MORSA.moduloEstacaoEspacial (id, nome, tipo, compLog, lancam, estacaoEspac)
  	values (@meeID, @meeNome, @meeTipo, @meeCompLog, @meeLanc, @meeEE)
    commit tran
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_updMEE @meeID as varchar(11), @meeNome as varchar(35), @meeTipo as varchar(20), @meeCompLog as char(9), @meeLanc as varchar(11), @meeEE as varchar(11)
as
begin
begin tran
	begin try
		update MORSA.moduloEstacaoEspacial
    set id = @meeID, nome = @meeNome, tipo = @meeTipo, compLog = @meeCompLog, lancam = @meeLanc, estacaoEspac = @meeEE
    where id = @meeID
    commit tran
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_delMEE @meeID as varchar(11)
as
begin
begin tran
	begin try
		delete MORSA.moduloEstacaoEspacial where id=@meeID
    commit tran
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_updOrbita @orbitaID as varchar(11), @orbitaApo as varchar(10), @orbitaPer as varchar(10), @orbitaInclin as varchar(7), @orbitaPeriodo as varchar(15), @orbitaAstro as varchar(11)
as
begin
begin tran
	begin try
		update MORSA.orbita
    set id = @orbitaID, apoastro = @orbitaApo, periastro = @orbitaPer, inclin = @orbitaInclin, periodo = @orbitaPeriodo, astro = @orbitaAstro
    where id = @orbitaID
    commit tran
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_delOrbita @orbID varchar(11)
as
begin
begin tran
	begin try
	if EXISTS(select * from MORSA.satelite where id = @orbID)
	begin
		DELETE MORSA.satelite_status WHERE MORSA.satelite_status.id=@orbID;
        DELETE MORSA.satelite_companhiasMae WHERE MORSA.satelite_companhiasMae.satelite=@orbID; 
        DELETE MORSA.satelite WHERE MORSA.satelite.id=@orbID;
		DELETE MORSA.orbita WHERE MORSA.orbita.id=@orbID;
		commit tran
	end
	else
	begin
		declare @compNif char(9);
		set @compNif = (select nif from MORSA.companhiaMae where MORSA.companhiaMae.estacaoEspac = @orbID);
		if Exists(select * from MORSA.satelite_companhiasMae where MORSA.satelite_companhiasMae.companhia = @compNif)
			update MORSA.companhiaMae set estacaoEspac = null where nif = @compNif;
		else
			delete from MORSA.companhiaMae where estacaoEspac = @orbID;
	
		delete from MORSA.estacaoEspacial_status where MORSA.estacaoEspacial_status.id = @orbID;
		delete from MORSA.moduloEstacaoEspacial where MORSA.moduloEstacaoEspacial.estacaoEspac = @orbID
		delete from MORSA.estacaoEspacial where MORSA.estacaoEspacial.id = @orbID;
		delete from MORSA.orbita where MORSA.orbita.id = @orbID;
		commit tran
	end
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_addLanc @lancID as varchar(11), @lancCoord as varchar(25), @lancPais as varchar(20), @lancDT as DATETIME,
	@veicName as varchar(35), @veicCompLog as char(9), @objID as varchar(11)
as
begin
begin tran
	begin try
		insert into MORSA.lancamento values (@lancID, @lancCoord, @lancPais, @lancDT);
		insert into MORSA.veiculoLancamento values (@lancID, @veicName, @veicCompLog);
		if EXISTS(select * from MORSA.satelite where MORSA.satelite.id = @objID)
			update MORSA.satelite set lancam = @lancID where MORSA.satelite.id = @objID;
		else if EXISTS(select * from MORSA.moduloEstacaoEspacial where MORSA.moduloEstacaoEspacial.id = @objID)
			update MORSA.moduloEstacaoEspacial set lancam = @lancID where id = @objID
		commit tran
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_searchLancObj (@lancID as varchar(11), @objID as varchar(11) OUTPUT)
as
begin
begin tran
	begin try
	if EXISTS(select * from MORSA.satelite where lancam = @lancID)
		set @objID = (select id from MORSA.satelite where lancam = @lancID)
	else if EXISTS(select * from MORSA.moduloEstacaoEspacial where lancam = @lancID)
		set @objID = (select id from MORSA.moduloEstacaoEspacial where lancam = @lancID)		
	commit tran
	end try
	begin catch
		rollback tran
	end catch
end

create proc MORSA.pr_updLanc @lancID as varchar(11), @lancCoord as varchar(25), @lancPais as varchar(20), @lancDT as DATETIME,
	@veicName as varchar(35), @veicCompLog as char(9), @objID as varchar(11)
as
begin
begin tran
begin try
	update MORSA.lancamento set id = @lancID, coord = @lancCoord, pais = @lancPais, dataTempo = @lancDT where id = @lancID; 
	update MORSA.veiculoLancamento set id = @lancID, nome = @veicName, compLog = @veicCompLog where id = @lancID;
	if EXISTS(select * from MORSA.satelite where MORSA.satelite.id = @objID)
			update MORSA.satelite set lancam = @lancID where MORSA.satelite.id = @objID;
	else if EXISTS(select * from MORSA.moduloEstacaoEspacial where MORSA.moduloEstacaoEspacial.id = @objID)
			update MORSA.moduloEstacaoEspacial set lancam = @lancID where id = @objID
commit tran
end try
begin catch
	rollback tran
end catch
end

create proc MORSA.pr_delLanc @lancID as varchar(11)
as
begin
begin tran
	begin try
		if EXISTS(select * from MORSA.satelite where lancam = @lancID)
			update MORSA.satelite set lancam = null where lancam = @lancID
		else if EXISTS(select * from MORSA.moduloEstacaoEspacial where lancam = @lancID)
			update MORSA.moduloEstacaoEspacial set lancam = null where lancam = @lancID
		delete from MORSA.veiculoLancamento where MORSA.veiculoLancamento.id = @lancID;
		delete from MORSA.lancamento where MORSA.lancamento.id = @lancID;
		commit tran
	end try
	begin catch
		rollback tran
	end catch
end




