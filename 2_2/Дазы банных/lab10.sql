use localdb;

CREATE TRIGGER before_trigger_delete 
    BEFORE delete ON cars
    FOR EACH ROW 
	SIGNAL SQLSTATE '227' SET MESSAGE_TEXT = 'Trigger delete error';


select * from Cars;