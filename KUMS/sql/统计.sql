update agent a set  a.physical_amount =( select sum(s.total_amount)  from Statement s where 1=1  and s.order_id in( select o.id  from finance_order o where o.agent_id=673 and o.tran_type in( 501,601,651,701,801,901 )  ) ) where a.id=673
