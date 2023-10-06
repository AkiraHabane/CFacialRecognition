-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 20, 2022 at 03:18 PM
-- Server version: 5.7.36
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `facialrecognition`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

DROP TABLE IF EXISTS `attendance`;
CREATE TABLE IF NOT EXISTS `attendance` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employee_no` varchar(100) NOT NULL,
  `employee_name` varchar(100) NOT NULL,
  `employee_dept` varchar(80) NOT NULL,
  `tdate` varchar(50) NOT NULL,
  `clocked_in_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`id`, `employee_no`, `employee_name`, `employee_dept`, `tdate`, `clocked_in_time`) VALUES
(1, 'emp001', 'Peter Kiptoo', 'IT', '20220802', '2022-08-02 15:50:55'),
(2, 'emp001', 'Peter Kiptoo', 'IT', '20220803', '2022-08-03 07:50:54'),
(3, 'emp005', 'pete', 'Select Employee Department', '20221016', '2022-10-16 07:48:32'),
(4, 'emp006', 'Pete', 'Software Engineering', '20221019', '2022-10-19 16:21:10');

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

DROP TABLE IF EXISTS `departments`;
CREATE TABLE IF NOT EXISTS `departments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `departments`
--

INSERT INTO `departments` (`id`, `name`) VALUES
(1, 'Software Engineering'),
(9, 'Finance'),
(10, 'Accounts'),
(12, 'IT');

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
CREATE TABLE IF NOT EXISTS `employees` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employee_no` varchar(100) NOT NULL,
  `employee_name` varchar(100) NOT NULL,
  `employee_dept` varchar(80) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`id`, `employee_no`, `employee_name`, `employee_dept`) VALUES
(1, 'emp001', 'Peter Kiptoo', 'IT'),
(2, 'emp002', 'John Doe', 'Finance'),
(3, 'emp005', 'sang', 'Software Engineering'),
(4, 'emp006', 'john', 'Finance'),
(5, 'emp09', 'peter', 'IT');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(80) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `email`, `password`) VALUES
(1, 'pete', 'pete@gmail.com', '120705DE7E61C5B322AD798B8EF225A7'),
(2, 'sang', 'sang@gmail.com', '120705DE7E61C5B322AD798B8EF225A7'),
(3, 'john', 'john@gmail.com', '120705DE7E61C5B322AD798B8EF225A7'),
(4, 'peter', 'peter@gmail.com', '120705DE7E61C5B322AD798B8EF225A7');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
