INSERT INTO public.user_detail(
	user_code, user_typeid, first_name, last_name, gender, date_of_birth, identity_id, identity_type, mobile_no, email, hashed_password, "CreatedBy", "UpdatedBy", "CreatedOn", "UpdatedOn")
	VALUES ('A1', 1, 'Mrugesh', 'Suthar', 'M', '31-08-1981', 'aadhar001', 'aadhdar card', 911111111, 'mrughesh@suthar.com', 'hashedpwdval', 1, 1, current_timestamp, current_timestamp);