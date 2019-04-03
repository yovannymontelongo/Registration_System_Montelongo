-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 29, 2019 at 01:32 AM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 7.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `registration_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `registration_table`
--

CREATE TABLE `registration_table` (
  `registration_id` int(8) NOT NULL,
  `student_id` int(8) NOT NULL,
  `section_id` int(8) NOT NULL,
  `date_registered` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `grade_earned` varchar(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `registration_table`
--

INSERT INTO `registration_table` (`registration_id`, `student_id`, `section_id`, `date_registered`, `grade_earned`) VALUES
(1, 1, 1, '2019-03-27 01:10:42', 'A');

-- --------------------------------------------------------

--
-- Table structure for table `section_table`
--

CREATE TABLE `section_table` (
  `section_id` int(8) NOT NULL,
  `teacher_id` int(8) NOT NULL,
  `course_name` varchar(30) NOT NULL,
  `section` varchar(15) NOT NULL,
  `days` varchar(15) NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `section_table`
--

INSERT INTO `section_table` (`section_id`, `teacher_id`, `course_name`, `section`, `days`, `start_time`, `end_time`) VALUES
(1, 1, 'ITSE', '1430', 'TuThu', '19:00:00', '21:30:00');

-- --------------------------------------------------------

--
-- Table structure for table `student_table`
--

CREATE TABLE `student_table` (
  `student_id` int(8) NOT NULL,
  `fname` varchar(30) NOT NULL,
  `lname` varchar(30) NOT NULL,
  `major` varchar(40) DEFAULT NULL,
  `degree` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_table`
--

INSERT INTO `student_table` (`student_id`, `fname`, `lname`, `major`, `degree`) VALUES
(1, 'Yovanny', 'Montelongo', 'Computer Science', 'B.S.'),
(3, 'Test First', 'Test Last', 'Test Major', 'Test Degree'),
(4, 'Test', 'test', 'tesT', 'TesT'),
(5, 'Shadow', 'McMillan', 'Meat', 'AAS');

-- --------------------------------------------------------

--
-- Table structure for table `teacher_table`
--

CREATE TABLE `teacher_table` (
  `teacher_id` int(8) NOT NULL,
  `fname` varchar(30) NOT NULL,
  `lname` varchar(30) NOT NULL,
  `title` varchar(30) DEFAULT NULL,
  `rank` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `teacher_table`
--

INSERT INTO `teacher_table` (`teacher_id`, `fname`, `lname`, `title`, `rank`) VALUES
(1, 'Tyson', 'McMillan', 'Dr.', 'Full Professor'),
(2, 'Test Teacher', 'Test Teacher Last', 'titleTEst', 'rank Test');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `registration_table`
--
ALTER TABLE `registration_table`
  ADD PRIMARY KEY (`registration_id`);

--
-- Indexes for table `section_table`
--
ALTER TABLE `section_table`
  ADD PRIMARY KEY (`section_id`);

--
-- Indexes for table `student_table`
--
ALTER TABLE `student_table`
  ADD PRIMARY KEY (`student_id`);

--
-- Indexes for table `teacher_table`
--
ALTER TABLE `teacher_table`
  ADD PRIMARY KEY (`teacher_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `registration_table`
--
ALTER TABLE `registration_table`
  MODIFY `registration_id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `section_table`
--
ALTER TABLE `section_table`
  MODIFY `section_id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `student_table`
--
ALTER TABLE `student_table`
  MODIFY `student_id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `teacher_table`
--
ALTER TABLE `teacher_table`
  MODIFY `teacher_id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
