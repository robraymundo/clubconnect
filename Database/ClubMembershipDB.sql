CREATE DATABASE IF NOT EXISTS ClubMembershipDB;
USE ClubMembershipDB;

CREATE TABLE Member (
    Member_ID INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(45) NOT NULL,
    last_name VARCHAR(45) NOT NULL,
    age INT UNSIGNED, 
    gender ENUM('Male', 'Female', 'Other'), 
    phone_number VARCHAR(20),
    email VARCHAR(100) UNIQUE, 
    address VARCHAR(255)
);

CREATE TABLE User (
    User_ID INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    role ENUM('User','Admin') DEFAULT 'User'
);


CREATE TABLE Club (
    Club_ID INT AUTO_INCREMENT PRIMARY KEY,
    club_name VARCHAR(100) NOT NULL,
    status ENUM('Active', 'Inactive') DEFAULT 'Active'
);

CREATE TABLE Membership (
    Membership_ID INT AUTO_INCREMENT PRIMARY KEY,
    Member_ID INT NOT NULL,
    Club_ID INT NOT NULL,
    date_joined DATE DEFAULT (CURRENT_DATE),
    membership_status ENUM('Active', 'Inactive', 'Expired') DEFAULT 'Active', 
    membership_type ENUM('Regular', 'Premium', 'VIP') DEFAULT 'Regular', 
    membership_fee DECIMAL(10,2) DEFAULT 0.00,
    FOREIGN KEY (Member_ID) REFERENCES Member(Member_ID) ON DELETE CASCADE,
    FOREIGN KEY (Club_ID) REFERENCES Club(Club_ID) ON DELETE CASCADE
);


CREATE TABLE Payment (
    Payment_ID INT AUTO_INCREMENT PRIMARY KEY,
    Membership_ID INT NOT NULL,
    amount DECIMAL(10, 2) NOT NULL,
    payment_date DATE DEFAULT (CURRENT_DATE),
    remarks VARCHAR(255),
    payment_method ENUM('Cash','Card','Online') DEFAULT 'Cash',
    payment_status ENUM('Paid','Pending','Failed') DEFAULT 'Paid',
    FOREIGN KEY (Membership_ID) REFERENCES Membership(Membership_ID) ON DELETE CASCADE
);

CREATE INDEX idx_member_id ON Membership(Member_ID);
CREATE INDEX idx_club_id ON Membership(Club_ID);
CREATE INDEX idx_membership_id ON Payment(Membership_ID);