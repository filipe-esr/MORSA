USE [p6g1]
GO
/****** Object:  User [p6g1]    Script Date: 06/06/2016 18:16:12 ******/
CREATE USER [p6g1] FOR LOGIN [p6g1] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [p6g1]
GO
/****** Object:  Schema [MORSA]    Script Date: 06/06/2016 18:16:12 ******/
CREATE SCHEMA [MORSA]
GO
/****** Object:  StoredProcedure [MORSA].[pr_addAstro]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_addAstro] @astroID as varchar(11), @astroTipo as varchar(20), @astroSistema as varchar(20), @astroGalaxia as varchar(20)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_addCompanhia]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_addCompanhia] @compNome as varchar(35), @compNIF as char(9), @compTelef as char(9), @compEnder as varchar(40), 
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_addEE]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_addEE] @eeID as varchar(11), @eeName as varchar(35), @paisOrg as varchar(30), @compLog as char(9),
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_addLanc]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_addLanc] @lancID as varchar(11), @lancCoord as varchar(25), @lancPais as varchar(20), @lancDT as DATETIME,
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_addMEE]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_addMEE] @meeID as varchar(11), @meeNome as varchar(35), @meeTipo as varchar(20), @meeCompLog as char(9), @meeLanc as varchar(11), @meeEE as varchar(11)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_addSatelite]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_addSatelite] @satID as varchar(11), @satName as varchar(35), @satService as varchar(20), @paisOrgan as varchar(20), @compLog as char(9),
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_advAstro]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_advAstro] @ID as varchar(11)
as
begin
begin tran
	begin try
  	if Exists(select * from MORSA.astro where id like '%'+@ID+'%')
    	select astro.id as Astro, orbita.id as ID, satelite.nome as Nome 
			from MORSA.astro join MORSA.orbita on MORSA.astro.id = MORSA.orbita.astro join MORSA.satelite on MORSA.orbita.id=MORSA.satelite.id
				where MORSA.astro.id like '%'+@ID+'%'
		UNION
		select astro.id as Astro, orbita.id as ID, estacaoEspacial.nome as Nome
			from MORSA.astro join MORSA.orbita on MORSA.astro.id = MORSA.orbita.astro join MORSA.estacaoEspacial on MORSA.orbita.id=MORSA.estacaoEspacial.id
				where MORSA.astro.id like '%'+@ID+'%'
    commit tran
  end try
  begin catch
  	rollback tran
  end catch
end
GO
/****** Object:  StoredProcedure [MORSA].[pr_advComp]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_advComp] @NIF as varchar(9), @sel as char(1)
as
begin
begin tran
	begin try
	If(@sel = '0')
		begin
  		if Exists(select * from MORSA.companhia where nif like '%'+@NIF+'%')
    		select C.nif as NIF, C.nome as Companhia, S.id as ID, S.nome as Nome
				from MORSA.companhia as C join MORSA.satelite_companhiasMae as SCM on C.nif = SCM.companhia  
					join MORSA.satelite as S on SCM.satelite = S.id
						where C.nif like '%'+@NIF+'%'
			UNION
			select C.nif as NIF, C.nome as Companhia, EE.id as ID, EE.nome as Nome
				from MORSA.companhia as C join MORSA.companhiaMae as CM on C.nif = CM.nif  
					join MORSA.estacaoEspacial as EE on CM.estacaoEspac = EE.id
						where C.nif like '%'+@NIF+'%'
		end
	 Else if(@sel = '1')
		 begin
			if Exists(select * from MORSA.companhia where nif like '%'+@NIF+'%')
				select C.nif as NIF, C.nome as Companhia, S.id as ID, S.nome as Nome
					from MORSA.companhia as C join MORSA.satelite as S on C.nif = S.compLog
						where C.nif like '%'+@NIF+'%'
			UNION
				select C.nif as NIF, C.nome as Companhia, EE.id as ID, EE.nome as Nome
					from MORSA.companhia as C join MORSA.estacaoEspacial as EE on C.nif = EE.compLog
						where C.nif like '%'+@NIF+'%' 
		 end
    commit tran
  end try
  begin catch
  	rollback tran
  end catch
end
GO
/****** Object:  StoredProcedure [MORSA].[pr_advCompLog]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_advCompLog] @NIF as varchar(9)
as
begin
begin tran
	begin try
  	if Exists(select * from MORSA.companhiaLogistica where nif like '%'+@NIF+'%')
    	select C.nif, C.nome, C.telef, C.sede
      from MORSA.companhia as C
      where C.nif like '%'+@NIF+'%'
    commit tran
  end try
  begin catch
  	rollback tran
  end catch
end
GO
/****** Object:  StoredProcedure [MORSA].[pr_advCompMae]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_advCompMae] @NIF as varchar(9)
as
begin
begin tran
	begin try
  	if Exists(select * from MORSA.companhiaMae where nif like '%'+@NIF+'%')
    	select C.nif, C.nome, C.telef, C.sede  
      from MORSA.companhiaMae as CM join MORSA.companhia as C on CM.nif = C.nif
      where CM.nif like '%'+@NIF+'%'
    commit tran
  end try
  begin catch
  	rollback tran
  end catch
end
GO
/****** Object:  StoredProcedure [MORSA].[pr_advLancVeic]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_advLancVeic] @ID as varchar(11), @sel as char(1)
as
begin
begin tran
  begin try
	if(@sel = '0')
	begin
    if Exists(select * from MORSA.satelite where id like '%'+@ID+'%')
		select S.id as satID, L.id as LancID, L.coord as LancCoord, L.pais as LancPais, L.dataTempo as DataTempo, VL.nome as Veiculo, VL.compLog as CompLog
			from MORSA.satelite as S join MORSA.lancamento as L on S.lancam = L.id join MORSA.veiculoLancamento as VL
				on L.id = VL.id where S.id like '%'+@ID+'%'
	end
	Else
	begin
	if Exists(select * from MORSA.moduloEstacaoEspacial where id like '%'+@ID+'%')
		select M.id as moduloID, L.id as LancID, L.coord as LancCoord, L.pais as LancPais, L.dataTempo as DataTempo, VL.nome as Veiculo, VL.compLog as CompLog
			from MORSA.moduloEstacaoEspacial as M join MORSA.lancamento as L on M.lancam = L.id join MORSA.veiculoLancamento as VL
				on L.id = VL.id where M.id like '%'+@ID+'%'
	end
    commit tran
	end try
	begin catch
		rollback tran
	end catch
end
GO
/****** Object:  StoredProcedure [MORSA].[pr_advModules]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_advModules] @ID as varchar(11)
as
begin
begin tran
  begin try
    if Exists(select * from MORSA.estacaoEspacial where id like '%'+@ID+'%')
      select EE.id as EstacaoID, MEE.id as ModuloID, MEE.nome as ModuloNome, MEE.tipo as ModuloTipo, MEE.compLog as CompLog, MEE.lancam as Lanc 
		from MORSA.estacaoEspacial as EE join MORSA.moduloEstacaoEspacial as MEE
			on EE.id = MEE.estacaoEspac where EE.id like '%'+@ID+'%'
    commit tran
	end try
	begin catch
		rollback tran
	end catch
end
GO
/****** Object:  StoredProcedure [MORSA].[pr_delAstro]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_delAstro] @astroID as varchar(11)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_delCompanhia]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_delCompanhia] @compNIF as char(9)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_delEE]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_delEE] @eeID as varchar(11)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_delLanc]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_delLanc] @lancID as varchar(11)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_delMEE]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_delMEE] @meeID as varchar(11)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_delOrbita]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_delOrbita] @orbID varchar(11)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_delSatelite]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_delSatelite] @satID as varchar(11)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_eeCompMae]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_eeCompMae] (@eeID varchar(11), @comp varchar(200) OUTPUT)	
as
begin tran
	select @comp = COALESCE(@comp + char(13),'')+ nif
	from MORSA.estacaoEspacial join MORSA.companhiaMae on id=estacaoEspac  where id=@eeID
commit tran
GO
/****** Object:  StoredProcedure [MORSA].[pr_satCompMae]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_satCompMae] (@satID varchar(11), @comp varchar(200) OUTPUT)
as
begin tran
	select @comp = COALESCE(@comp + char(13),'')+ companhia
	from MORSA.satelite_companhiasMae where satelite=@satID
commit tran

GO
/****** Object:  StoredProcedure [MORSA].[pr_searchAstro]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_searchAstro](@astroID varchar(11))
as
begin tran
	select * from MORSA.astro where id like '%'+@astroID+'%'
commit tran

GO
/****** Object:  StoredProcedure [MORSA].[pr_searchCompanhia]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_searchCompanhia](@compNome varchar(35), @compNif varchar(9))
as
begin tran
	if(@compNif is null)
	begin
		select * from MORSA.companhia where nome like '%'+@compNome+'%'
	end
	else if(@compNome is null)
	begin
		select * from MORSA.companhia where nif like '%'+@compNif+'%'
	end
commit tran
GO
/****** Object:  StoredProcedure [MORSA].[pr_searchEstacaoEspac]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_searchEstacaoEspac](@eeNome varchar(35), @eeID varchar(11))
as
begin tran
	if(@eeID is null)
	begin
		select * from MORSA.estacaoEspacial join MORSA.estacaoEspacial_status on MORSA.estacaoEspacial.id=MORSA.estacaoEspacial_status.id 
		where nome like '%'+@eeNome+'%'
	end
	else if(@eeNome is null)
	begin
		select * from MORSA.estacaoEspacial join MORSA.estacaoEspacial_status on MORSA.estacaoEspacial.id=MORSA.estacaoEspacial_status.id
		where MORSA.estacaoEspacial.id like '%'+@eeID+'%'
	end
commit tran
GO
/****** Object:  StoredProcedure [MORSA].[pr_searchLancamento]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_searchLancamento](@lancID varchar(11))
as
begin tran
	select * from MORSA.lancamento join MORSA.veiculoLancamento on MORSA.lancamento.id=MORSA.veiculoLancamento.id
	where MORSA.lancamento.id like '%'+@lancID+'%'
commit tran
GO
/****** Object:  StoredProcedure [MORSA].[pr_searchLancObj]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_searchLancObj] (@lancID as varchar(11), @objID as varchar(11) OUTPUT)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_searchModuloEE]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_searchModuloEE](@mEENome varchar(35), @mEEID varchar(11))
as
begin tran
	if(@mEEID is null)
	begin
		select * from MORSA.moduloEstacaoEspacial where nome like '%'+@mEENome+'%'
	end
	else if(@mEENome is null)
	begin
		select * from MORSA.moduloEstacaoEspacial where id like '%'+@mEEID+'%'
	end
commit tran
GO
/****** Object:  StoredProcedure [MORSA].[pr_searchOrbita]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_searchOrbita](@orbID varchar(11))
as
begin tran
	select * from MORSA.orbita where id like '%'+@orbID+'%'
commit tran
GO
/****** Object:  StoredProcedure [MORSA].[pr_searchSatelite]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_searchSatelite](@satNome varchar(35), @satID varchar(11))
as
begin tran
	if(@satID is null)
	begin
		select * from MORSA.satelite join MORSA.satelite_status on MORSA.satelite.id=MORSA.satelite_status.id 
		where nome like '%'+@satNome+'%'
	end
	else if(@satNome is null)
	begin
		select * from MORSA.satelite join MORSA.satelite_status on MORSA.satelite.id=MORSA.satelite_status.id 
		where MORSA.satelite.id like '%'+@satID+'%'
	end
commit tran
GO
/****** Object:  StoredProcedure [MORSA].[pr_updAstro]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_updAstro] @astroID as varchar(11), @astroTipo as varchar(20), @astroSistema as varchar(20), @astroGalaxia as varchar(20)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_updCompanhia]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_updCompanhia] @compNome as varchar(35), @compNIF as char(9), @compTelef as char(9), @compEnder as varchar(40), 
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_updEE]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_updEE] @eeID as varchar(11), @eeName as varchar(35), @paisOrg as varchar(30), @compLog as char(9), @status as varchar(9)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_updLanc]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_updLanc] @lancID as varchar(11), @lancCoord as varchar(25), @lancPais as varchar(20), @lancDT as DATETIME,
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_updMEE]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_updMEE] @meeID as varchar(11), @meeNome as varchar(35), @meeTipo as varchar(20), @meeCompLog as char(9), @meeLanc as varchar(11), @meeEE as varchar(11)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_updOrbita]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_updOrbita] @orbitaID as varchar(11), @orbitaApo as varchar(10), @orbitaPer as varchar(10), @orbitaInclin as varchar(7), @orbitaPeriodo as varchar(15), @orbitaAstro as varchar(11)
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
GO
/****** Object:  StoredProcedure [MORSA].[pr_updSatelite]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [MORSA].[pr_updSatelite] @satID as varchar(11), @satName as varchar(35), @satService as varchar(20), @paisOrgan as varchar(20), @compLog as char(9), @lancam as varchar(11)
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
GO
/****** Object:  Table [MORSA].[astro]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[astro](
	[id] [varchar](11) NOT NULL,
	[tipo] [varchar](20) NOT NULL,
	[sistema] [varchar](20) NOT NULL,
	[galaxia] [varchar](20) NOT NULL,
 CONSTRAINT [astroPK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [MORSA].[companhia]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[companhia](
	[nome] [varchar](35) NOT NULL,
	[nif] [char](9) NOT NULL,
	[telef] [char](9) NOT NULL,
	[ender] [varchar](40) NOT NULL,
	[codPos] [char](8) NOT NULL,
	[sede] [varchar](20) NOT NULL,
 CONSTRAINT [companhiaPK] PRIMARY KEY CLUSTERED 
(
	[nif] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [MORSA].[companhiaLogistica]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[companhiaLogistica](
	[nif] [char](9) NOT NULL,
 CONSTRAINT [companhiaLogisticaPK] PRIMARY KEY CLUSTERED 
(
	[nif] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [MORSA].[companhiaMae]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[companhiaMae](
	[nif] [char](9) NOT NULL,
	[estacaoEspac] [varchar](11) NULL,
 CONSTRAINT [companhiaMaePK] PRIMARY KEY CLUSTERED 
(
	[nif] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [MORSA].[estacaoEspacial]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[estacaoEspacial](
	[id] [varchar](11) NOT NULL,
	[nome] [varchar](35) NULL,
	[paisOrgan] [varchar](30) NULL,
	[compLog] [char](9) NOT NULL,
 CONSTRAINT [estacaoEspacialPK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [MORSA].[estacaoEspacial_status]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[estacaoEspacial_status](
	[id] [varchar](11) NOT NULL,
	[status] [varchar](9) NOT NULL,
 CONSTRAINT [estacaoEspacial_statusPK] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [MORSA].[lancamento]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[lancamento](
	[id] [varchar](11) NOT NULL,
	[coord] [varchar](25) NOT NULL,
	[pais] [varchar](20) NULL,
	[dataTempo] [datetime] NOT NULL,
 CONSTRAINT [lancamentoPK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [MORSA].[moduloEstacaoEspacial]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[moduloEstacaoEspacial](
	[id] [varchar](11) NOT NULL,
	[nome] [varchar](35) NULL,
	[tipo] [varchar](20) NULL,
	[compLog] [char](9) NOT NULL,
	[lancam] [varchar](11) NULL,
	[estacaoEspac] [varchar](11) NOT NULL,
 CONSTRAINT [moduloEstacaoEspacialPK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [MORSA].[orbita]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[orbita](
	[id] [varchar](11) NOT NULL,
	[apoastro] [varchar](10) NOT NULL,
	[periastro] [varchar](10) NOT NULL,
	[inclin] [varchar](7) NOT NULL,
	[periodo] [varchar](15) NOT NULL,
	[astro] [varchar](11) NULL,
 CONSTRAINT [orbitaPK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [MORSA].[satelite]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[satelite](
	[id] [varchar](11) NOT NULL,
	[nome] [varchar](35) NULL,
	[servico] [varchar](20) NULL,
	[paisOrgan] [varchar](20) NULL,
	[compLog] [char](9) NOT NULL,
	[lancam] [varchar](11) NULL,
 CONSTRAINT [satelitePK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [MORSA].[satelite_companhiasMae]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[satelite_companhiasMae](
	[satelite] [varchar](11) NOT NULL,
	[companhia] [char](9) NOT NULL,
 CONSTRAINT [satelite_companhiasMaePK] PRIMARY KEY CLUSTERED 
(
	[satelite] ASC,
	[companhia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [MORSA].[satelite_status]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[satelite_status](
	[id] [varchar](11) NOT NULL,
	[status] [varchar](9) NOT NULL,
 CONSTRAINT [satelite_statusPK] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [MORSA].[veiculoLancamento]    Script Date: 06/06/2016 18:16:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [MORSA].[veiculoLancamento](
	[id] [varchar](11) NOT NULL,
	[nome] [varchar](35) NULL,
	[compLog] [char](9) NOT NULL,
 CONSTRAINT [veiculoLancamentoPK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Deimos', N'Moon', N'Solar System', N'Milky Way')
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Earth', N'Planet', N'Solar System', N'Milky Way')
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Jupiter', N'Planet', N'Solar System', N'Milky Way')
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Mars', N'Planet', N'Solar System', N'Milky Way')
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Mercury', N'Planet', N'Solar System', N'Milky Way')
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Moon', N'Moon', N'Solar System', N'Milky Way')
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Neptune', N'Planet', N'Solar System', N'Milky Way')
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Phobos', N'Moon', N'Solar System', N'Milky Way')
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Pluto', N'Planet', N'Solar System', N'Milky Way')
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Saturn', N'Planet', N'Solar System', N'Milky Way')
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Sun', N'Star', N'Solar System', N'Milky Way')
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Uranus', N'Planet', N'Solar System', N'Milky Way')
INSERT [MORSA].[astro] ([id], [tipo], [sistema], [galaxia]) VALUES (N'Venus', N'Planet', N'Solar System', N'Milky Way')
INSERT [MORSA].[companhia] ([nome], [nif], [telef], [ender], [codPos], [sede]) VALUES (N'ESA', N'190123123', N'225123123', N'Paris, rue Joane d''Arc 201', N'432-1231', N'France')
INSERT [MORSA].[companhia] ([nome], [nif], [telef], [ender], [codPos], [sede]) VALUES (N'JAXA', N'400456321', N'600132528', N'4-6 Kandasurugadai, Chiyoda-ku, Tokyo', N'101-8008', N'Japan')
INSERT [MORSA].[companhia] ([nome], [nif], [telef], [ender], [codPos], [sede]) VALUES (N'CNSA', N'500123789', N'400500600', N'Guo Jia Hang Tian Ju, China', N'6344-123', N'China')
INSERT [MORSA].[companhia] ([nome], [nif], [telef], [ender], [codPos], [sede]) VALUES (N'Roscosmos', N'707800800', N'300321321', N'Schepkina st. 42, Moscow, Russia', N'01079-96', N'Russia')
INSERT [MORSA].[companhia] ([nome], [nif], [telef], [ender], [codPos], [sede]) VALUES (N'USDOD', N'901098765', N'555900142', N'Olympia, WA 98504-7476', N'7685-033', N'USA')
INSERT [MORSA].[companhia] ([nome], [nif], [telef], [ender], [codPos], [sede]) VALUES (N'NASA', N'901321321', N'555123123', N'300 E. Street SW Washington, DC', N'1232-421', N'USA')
INSERT [MORSA].[companhia] ([nome], [nif], [telef], [ender], [codPos], [sede]) VALUES (N'SpaceX', N'901456456', N'555456456', N'1030 15th Street N.W.', N'1432-123', N'USA')
INSERT [MORSA].[companhiaLogistica] ([nif]) VALUES (N'190123123')
INSERT [MORSA].[companhiaLogistica] ([nif]) VALUES (N'500123789')
INSERT [MORSA].[companhiaLogistica] ([nif]) VALUES (N'707800800')
INSERT [MORSA].[companhiaLogistica] ([nif]) VALUES (N'901098765')
INSERT [MORSA].[companhiaLogistica] ([nif]) VALUES (N'901321321')
INSERT [MORSA].[companhiaLogistica] ([nif]) VALUES (N'901456456')
INSERT [MORSA].[companhiaMae] ([nif], [estacaoEspac]) VALUES (N'190123123', N'1998-067A')
INSERT [MORSA].[companhiaMae] ([nif], [estacaoEspac]) VALUES (N'500123789', NULL)
INSERT [MORSA].[companhiaMae] ([nif], [estacaoEspac]) VALUES (N'707800800', N'1998-067A')
INSERT [MORSA].[companhiaMae] ([nif], [estacaoEspac]) VALUES (N'901098765', NULL)
INSERT [MORSA].[companhiaMae] ([nif], [estacaoEspac]) VALUES (N'901321321', N'1998-067A')
INSERT [MORSA].[companhiaMae] ([nif], [estacaoEspac]) VALUES (N'901456456', N'1998-067A')
INSERT [MORSA].[estacaoEspacial] ([id], [nome], [paisOrgan], [compLog]) VALUES (N'1998-067A', N'ISS', N'NASA/Roscosmos/JAXA/ESA', N'901321321')
INSERT [MORSA].[estacaoEspacial] ([id], [nome], [paisOrgan], [compLog]) VALUES (N'2011-053A', N'Tiangong 1', N'CNSA', N'500123789')
INSERT [MORSA].[estacaoEspacial_status] ([id], [status]) VALUES (N'1998-067A', N'ATIVO')
INSERT [MORSA].[estacaoEspacial_status] ([id], [status]) VALUES (N'2011-053A', N'PROJETADO')
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'1990-103RL', N'W 28.408 N -80.602', N'USA', CAST(0x0000813C007F656D AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'1993-068RL', N'W 28.408 N -80.602', N'USA', CAST(0x000084CD004DF57B AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'1998-067RL', N'W 44.121 N 40.659', N'Russia', CAST(0x00008BD300000000 AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2000-000RL', N'W 5.355 N -53.003', N'French Guiana', CAST(0x00008EAC00A4CB9E AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2000-004RL', N'W 5.355 N -53.003', N'French Guiana', CAST(0x00008F6200A046DA AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2000-025RL', N'W 5.355 N -53.003', N'French Guiana', CAST(0x00008EEC002466E7 AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2000-040RL', N'W 5.355 N -53.003', N'French Guiana', CAST(0x00008F0000455C67 AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2000-071RL', N'W 5.355 N -53.003', N'French Guiana', CAST(0x00008F2D00135D08 AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2008-048RL', N'W 28.408 N -80.602', N'USA', CAST(0x00009A40015AFC45 AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2011-053RL', N'W 29.112 N -238.048', N'China', CAST(0x00009E9200A5AAAF AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2011-054RL', N'W 29.112 N -238.048', N'China', CAST(0x00009E9200AB28EF AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2013-055RL', N'W 28.408 N -80.602', N'USA', CAST(0x0000A19E0011598D AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2014-026RL', N'W 28.408 N -80.602', N'USA', CAST(0x0000A318002466E7 AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2014-045RL', N'W 28.408 N -80.602', N'USA', CAST(0x0000A37100000000 AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2014-068RL', N'W 28.408 N -80.602', N'USA', CAST(0x0000A3A600D9AD27 AS DateTime))
INSERT [MORSA].[lancamento] ([id], [coord], [pais], [dataTempo]) VALUES (N'2015-013RL', N'W 28.408 N -80.602', N'USA', CAST(0x0000A3FD0169462F AS DateTime))
INSERT [MORSA].[moduloEstacaoEspacial] ([id], [nome], [tipo], [compLog], [lancam], [estacaoEspac]) VALUES (N'1998-067B', N'Sputnik', N'Comunication', N'707800800', NULL, N'1998-067A')
INSERT [MORSA].[moduloEstacaoEspacial] ([id], [nome], [tipo], [compLog], [lancam], [estacaoEspac]) VALUES (N'2001-089C', N'Flora', N'Investigation', N'190123123', NULL, N'1998-067A')
INSERT [MORSA].[moduloEstacaoEspacial] ([id], [nome], [tipo], [compLog], [lancam], [estacaoEspac]) VALUES (N'2011-053B', N'YoungYu', N'Central', N'500123789', N'2011-053RL', N'2011-053A')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'1990-103A', N'20488km', N'19889km', N'54.25', N'717.94min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'1993-068A', N'20510km', N'19868km', N'53.98º', N'717.94min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'1998-067A', N'413km', N'411km', N'51.64º', N'92.66min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'2000-000A', N'19123km', N'19123km', N'55.00º', N'590.00min', N'Mars')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'2000-004A', N'20647km', N'19732km', N'53.00º', N'717.98min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'2000-025A', N'20308km', N'20072km', N'53.07º', N'718.00min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'2000-040A', N'20720km', N'19657km', N'56.70º', N'717.95min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'2000-071A', N'20424km', N'19962km', N'55.25º', N'718.11min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'2008-048A', N'639km', N'620km', N'9.35º', N'97.15min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'2011-053A', N'402km', N'384km', N'42.76º', N'92.27min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'2013-055G', N'1270km', N'321km', N'80.97º', N'100.63min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'2014-026A', N'20207km', N'20172km', N'55.23º', N'717.98min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'2014-045A', N'20200km', N'20177km', N'54.74º', N'717.95min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'2014-068A', N'20201km', N'20179km', N'54.96º', N'718.00min', N'Earth')
INSERT [MORSA].[orbita] ([id], [apoastro], [periastro], [inclin], [periodo], [astro]) VALUES (N'2015-013A', N'20217km', N'20163km', N'55.04º', N'718.00min', N'Earth')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'1990-103A', N'NAVSTAR 22', N'GPS', N'USA', N'901098765', N'1990-103RL')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'1993-068A', N'NAVSTAR 35', N'GPS', N'USA', N'901098765', N'1993-068RL')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'2000-000A', N'GALILEO', N'Research', N'ESA', N'190123123', N'2000-000RL')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'2000-004A', N'NAVSTAR 50', N'GPS', N'USA', N'901098765', N'2000-004RL')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'2000-025A', N'NAVSTAR 47', N'GPS', N'USA', N'901098765', N'2000-025RL')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'2000-040A', N'NAVSTAR 48', N'GPS', N'USA', N'901098765', N'2000-040RL')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'2000-071A', N'NAVSTAR 49', N'GPS', N'USA', N'901098765', N'2000-071RL')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'2008-048A', N'DEMOSAT', N'Research', N'USA', N'901456456', N'2008-048RL')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'2013-055G', N'CUSAT 2', N'Research', N'USA', N'901456456', N'2013-055RL')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'2014-026A', N'NAVSTAR 70', N'GPS', N'USA', N'901098765', N'2014-026RL')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'2014-045A', N'NAVSTAR 71', N'GPS', N'USA', N'901098765', N'2014-045RL')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'2014-068A', N'NAVSTAR 72', N'GPS', N'USA', N'901098765', N'2014-068RL')
INSERT [MORSA].[satelite] ([id], [nome], [servico], [paisOrgan], [compLog], [lancam]) VALUES (N'2015-013A', N'NAVSTAR 73', N'GPS', N'USA', N'901098765', N'2015-013RL')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'1990-103A', N'190123123')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'1990-103A', N'901098765')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'1993-068A', N'901098765')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'2000-000A', N'190123123')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'2000-000A', N'901456456')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'2000-004A', N'901098765')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'2000-025A', N'901098765')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'2000-040A', N'901098765')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'2000-071A', N'901098765')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'2008-048A', N'901456456')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'2013-055G', N'901456456')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'2014-026A', N'901098765')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'2014-045A', N'901098765')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'2014-068A', N'901098765')
INSERT [MORSA].[satelite_companhiasMae] ([satelite], [companhia]) VALUES (N'2015-013A', N'901098765')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'1990-103A', N'DESATIVO')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'1993-068A', N'DESATIVO')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'2000-000A', N'ATIVO')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'2000-004A', N'ATIVO')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'2000-025A', N'ATIVO')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'2000-040A', N'ATIVO')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'2000-071A', N'ATIVO')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'2008-048A', N'ATIVO')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'2013-055G', N'ATIVO')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'2014-026A', N'ATIVO')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'2014-045A', N'ATIVO')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'2014-068A', N'ATIVO')
INSERT [MORSA].[satelite_status] ([id], [status]) VALUES (N'2015-013A', N'ATIVO')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'1990-103RL', N'Eagle1', N'901321321')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'1993-068RL', N'Eagle2', N'901321321')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'1998-067RL', N'SoyuzM', N'707800800')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2000-000RL', N'Atlas', N'901456456')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2000-004RL', N'Ariane5', N'190123123')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2000-025RL', N'Ariane1', N'190123123')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2000-040RL', N'Ariane2', N'190123123')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2000-071RL', N'Ariane4', N'190123123')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2008-048RL', N'Eagle5', N'901321321')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2011-053RL', N'Tiguyon1', N'500123789')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2011-054RL', N'Yin-Yang', N'500123789')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2013-055RL', N'Eagle11', N'901321321')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2014-026RL', N'FALCON-1', N'901456456')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2014-045RL', N'FALCON-2', N'901456456')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2014-068RL', N'FALCON-3', N'901456456')
INSERT [MORSA].[veiculoLancamento] ([id], [nome], [compLog]) VALUES (N'2015-013RL', N'FALCON-9', N'901456456')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__companhi__C3D211542880B8D7]    Script Date: 06/06/2016 18:16:13 ******/
ALTER TABLE [MORSA].[companhia] ADD UNIQUE NONCLUSTERED 
(
	[telef] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [MORSA].[companhiaLogistica]  WITH CHECK ADD  CONSTRAINT [companhiaLogisticaFK_nif] FOREIGN KEY([nif])
REFERENCES [MORSA].[companhia] ([nif])
GO
ALTER TABLE [MORSA].[companhiaLogistica] CHECK CONSTRAINT [companhiaLogisticaFK_nif]
GO
ALTER TABLE [MORSA].[companhiaMae]  WITH CHECK ADD  CONSTRAINT [companhiaMaeFK_estacaoEspac] FOREIGN KEY([estacaoEspac])
REFERENCES [MORSA].[estacaoEspacial] ([id])
GO
ALTER TABLE [MORSA].[companhiaMae] CHECK CONSTRAINT [companhiaMaeFK_estacaoEspac]
GO
ALTER TABLE [MORSA].[companhiaMae]  WITH CHECK ADD  CONSTRAINT [companhiaMaeFK_nif] FOREIGN KEY([nif])
REFERENCES [MORSA].[companhia] ([nif])
GO
ALTER TABLE [MORSA].[companhiaMae] CHECK CONSTRAINT [companhiaMaeFK_nif]
GO
ALTER TABLE [MORSA].[estacaoEspacial]  WITH CHECK ADD  CONSTRAINT [estacaoEspacialFK_compLog] FOREIGN KEY([compLog])
REFERENCES [MORSA].[companhiaLogistica] ([nif])
GO
ALTER TABLE [MORSA].[estacaoEspacial] CHECK CONSTRAINT [estacaoEspacialFK_compLog]
GO
ALTER TABLE [MORSA].[estacaoEspacial]  WITH CHECK ADD  CONSTRAINT [estacaoEspacialFK_PK] FOREIGN KEY([id])
REFERENCES [MORSA].[orbita] ([id])
GO
ALTER TABLE [MORSA].[estacaoEspacial] CHECK CONSTRAINT [estacaoEspacialFK_PK]
GO
ALTER TABLE [MORSA].[estacaoEspacial_status]  WITH CHECK ADD  CONSTRAINT [estacaoEspacial_statusFK] FOREIGN KEY([id])
REFERENCES [MORSA].[estacaoEspacial] ([id])
GO
ALTER TABLE [MORSA].[estacaoEspacial_status] CHECK CONSTRAINT [estacaoEspacial_statusFK]
GO
ALTER TABLE [MORSA].[moduloEstacaoEspacial]  WITH CHECK ADD  CONSTRAINT [moduloEstacaoEspacialFK_compLog] FOREIGN KEY([compLog])
REFERENCES [MORSA].[companhiaLogistica] ([nif])
GO
ALTER TABLE [MORSA].[moduloEstacaoEspacial] CHECK CONSTRAINT [moduloEstacaoEspacialFK_compLog]
GO
ALTER TABLE [MORSA].[moduloEstacaoEspacial]  WITH CHECK ADD  CONSTRAINT [moduloEstacaoEspacialFK_estacaoEspac] FOREIGN KEY([estacaoEspac])
REFERENCES [MORSA].[estacaoEspacial] ([id])
GO
ALTER TABLE [MORSA].[moduloEstacaoEspacial] CHECK CONSTRAINT [moduloEstacaoEspacialFK_estacaoEspac]
GO
ALTER TABLE [MORSA].[moduloEstacaoEspacial]  WITH CHECK ADD  CONSTRAINT [moduloEstacaoEspacialFK_lancam] FOREIGN KEY([lancam])
REFERENCES [MORSA].[lancamento] ([id])
GO
ALTER TABLE [MORSA].[moduloEstacaoEspacial] CHECK CONSTRAINT [moduloEstacaoEspacialFK_lancam]
GO
ALTER TABLE [MORSA].[orbita]  WITH CHECK ADD  CONSTRAINT [orbitaFK_astro] FOREIGN KEY([astro])
REFERENCES [MORSA].[astro] ([id])
GO
ALTER TABLE [MORSA].[orbita] CHECK CONSTRAINT [orbitaFK_astro]
GO
ALTER TABLE [MORSA].[satelite]  WITH CHECK ADD  CONSTRAINT [sateliteFK_compLog] FOREIGN KEY([compLog])
REFERENCES [MORSA].[companhiaLogistica] ([nif])
GO
ALTER TABLE [MORSA].[satelite] CHECK CONSTRAINT [sateliteFK_compLog]
GO
ALTER TABLE [MORSA].[satelite]  WITH CHECK ADD  CONSTRAINT [sateliteFK_lancam] FOREIGN KEY([lancam])
REFERENCES [MORSA].[lancamento] ([id])
GO
ALTER TABLE [MORSA].[satelite] CHECK CONSTRAINT [sateliteFK_lancam]
GO
ALTER TABLE [MORSA].[satelite]  WITH CHECK ADD  CONSTRAINT [sateliteFK_PK] FOREIGN KEY([id])
REFERENCES [MORSA].[orbita] ([id])
GO
ALTER TABLE [MORSA].[satelite] CHECK CONSTRAINT [sateliteFK_PK]
GO
ALTER TABLE [MORSA].[satelite_companhiasMae]  WITH CHECK ADD  CONSTRAINT [satelite_companhiasMaeFK_companhia] FOREIGN KEY([companhia])
REFERENCES [MORSA].[companhiaMae] ([nif])
GO
ALTER TABLE [MORSA].[satelite_companhiasMae] CHECK CONSTRAINT [satelite_companhiasMaeFK_companhia]
GO
ALTER TABLE [MORSA].[satelite_companhiasMae]  WITH CHECK ADD  CONSTRAINT [satelite_companhiasMaeFK_satelite] FOREIGN KEY([satelite])
REFERENCES [MORSA].[satelite] ([id])
GO
ALTER TABLE [MORSA].[satelite_companhiasMae] CHECK CONSTRAINT [satelite_companhiasMaeFK_satelite]
GO
ALTER TABLE [MORSA].[satelite_status]  WITH CHECK ADD  CONSTRAINT [satelite_statusFK] FOREIGN KEY([id])
REFERENCES [MORSA].[satelite] ([id])
GO
ALTER TABLE [MORSA].[satelite_status] CHECK CONSTRAINT [satelite_statusFK]
GO
ALTER TABLE [MORSA].[veiculoLancamento]  WITH CHECK ADD  CONSTRAINT [veiculoLancamentoFK] FOREIGN KEY([compLog])
REFERENCES [MORSA].[companhiaLogistica] ([nif])
GO
ALTER TABLE [MORSA].[veiculoLancamento] CHECK CONSTRAINT [veiculoLancamentoFK]
GO
ALTER TABLE [MORSA].[veiculoLancamento]  WITH CHECK ADD  CONSTRAINT [veiculoLancamentoFK_PK] FOREIGN KEY([id])
REFERENCES [MORSA].[lancamento] ([id])
GO
ALTER TABLE [MORSA].[veiculoLancamento] CHECK CONSTRAINT [veiculoLancamentoFK_PK]
GO
