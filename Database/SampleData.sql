USE ClubMembershipDB;

INSERT INTO User (username, password, role)
VALUES 
('admin', 'admin123', 'Admin');

INSERT INTO User (username, password, role)
VALUES
('user1', 'user123', 'User'),
('user2', 'password123', 'User'),
('user3', '123', 'User');

INSERT INTO Member (first_name, last_name, age, gender, phone_number, email, address)
VALUES
('John', 'Doe', 25, 'Male', '09171234567', 'john@example.com', '123 Street, City'),
('Jane', 'Smith', 28, 'Female', '09179876543', 'jane@example.com', '456 Avenue, City'),
('Robin', 'Pogi', 20, 'Male', '09166028942', 'ob@example.com', 'Ilagan City');


INSERT INTO Club (club_name, status)
VALUES
('AWS Club', 'Active'),
('GDSC Club', 'Active'),
('Canva Club', 'Active');

INSERT INTO Membership (Member_ID, Club_ID, membership_status, membership_type, membership_fee)
VALUES
(1, 1, 'Active', 'Regular', 150.00),
(2, 2, 'Active', 'Premium', 300.00),
(3, 3, 'Active', 'VIP', 500.00);

-- Sample Payments
INSERT INTO Payment (Membership_ID, amount, payment_status, payment_method, remarks)
VALUES
(1, 100.00, 'Paid', 'Cash', 'Initial payment'),
(2, 200.00, 'Pending', 'Online', 'Initial payment pending');

