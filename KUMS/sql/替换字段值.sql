select f.*,f.rowid from data_type f ;
select f.*,f.rowid from finance_order f order by f.id desc;
select f.*,f.rowid from finance_order f where f.tran_type=120130;
select f.*,f.rowid from finance_order f where f.memo like '%����%';
select f.* from finance_order f where f.memo like '%�ؽ�%';

select t.* from company t where t.name like '%������%';

update finance_order f set f.cussent_company_id=538 where f.memo like '%�ؽ�%';
update finance_order f set f.cussent_company_id=539 where f.memo like '%��%';
update finance_order f set f.cussent_company_id=540 where f.memo like '%����%';
update finance_order f set f.cussent_company_id=542 where f.memo like '%��֮��%';
update finance_order f set f.cussent_company_id=543 where f.memo like '%��һ��%';
update finance_order f set f.cussent_company_id=547 where f.tran_type=120130;//������
update finance_order f set f.cussent_company_id=549 where f.memo like '%������%';
update finance_order f set f.cussent_company_id=561 where f.memo like '%��Ե%';
update finance_order f set f.cussent_company_id=574 where f.memo like '%���幫%';
update finance_order f set f.cussent_company_id=580 where f.memo like '%³��%';
update finance_order f set f.cussent_company_id=581 where f.memo like '%����%';
update finance_order f set f.cussent_company_id=582 where f.memo like '%����ţ%';


select f.* from finance_order f where f.cussent_company_id>0;

update finance_order f set f.memo=replace(f.memo,'�ؽ�2','�ؽ�') where f.memo like '%�ؽ�%';


