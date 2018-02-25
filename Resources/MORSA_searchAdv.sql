-- Advanced Search 1)
-- Ver info de lancamento/VeicLanc pesquisando por qualquer ID
create proc MORSA.pr_advLancVeic @ID as varchar(11), @sel as char(1)
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

-- Advanced Search 2)
-- Ver todos os modulos pesquisando por qualquer EE.id
create proc MORSA.pr_advModules @ID as varchar(11)
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

drop proc pr_advModules
-- Advanced Search 3)
-- Ver todas as Orbitas/Objectos de um qualquer Astro
create proc MORSA.pr_advAstro @ID as varchar(11)
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

-- Advanced Search 4)
-- Ver todos os Sat e EE pesquisando por uma companhia
create proc MORSA.pr_advComp @NIF as varchar(9), @sel as char(1)
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

-- Advanced Search 5)
-- Ver companhias Mae
create proc MORSA.pr_advCompMae @NIF as varchar(9)
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

-- Advanced Search 6)
-- ver companhias Log
create proc MORSA.pr_advCompLog @NIF as varchar(9)
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