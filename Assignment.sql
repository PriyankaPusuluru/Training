CREATE SCHEMA school;
CREATE TABLE school.students (
    student_id INTEGER PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    email VARCHAR(100) UNIQUE,
    city VARCHAR(50),
    joined_date DATE
);
CREATE TABLE school.courses (
    course_id INTEGER PRIMARY KEY,
    course_name VARCHAR(100) NOT NULL,
    instructor VARCHAR(100),
    fee DECIMAL(10,2)
);
CREATE TABLE school.enrollments (
    enrollment_id INTEGER PRIMARY KEY,
    student_id INTEGER,
    course_id INTEGER,
    enrollment_date DATE,
    grade INTEGER,

    FOREIGN KEY (student_id)
        REFERENCES school.students(student_id),

    FOREIGN KEY (course_id)
        REFERENCES school.courses(course_id)
);
INSERT INTO school.students
    (student_id, first_name, last_name, email, city, joined_date)
VALUES
    (1, 'John', 'Smith', 'john@gmail.com', 'New York', '2024-01-10'),
    (2, 'Emma', 'Brown', 'emma@gmail.com', 'Chicago', '2024-02-15'),
    (3, 'David', 'Wilson', 'david@gmail.com', 'Boston', '2024-03-20'),
    (4, 'Sophia', 'Davis', 'sophia@gmail.com', 'Dallas', '2024-04-12'),
    (5, 'Michael', 'Taylor', 'michael@gmail.com', 'Seattle', '2024-05-05');
   SELECT *
FROM school.students;
INSERT INTO school.courses
    (course_id, course_name, instructor, fee)
VALUES
    (101, 'SQL', 'Robert', 500.00),
    (102, 'Python', 'Jennifer', 600.00),
    (103, 'Data Analytics', 'William', 750.00),
    (104, 'Power BI', 'Sarah', 450.00);
    SELECT *
FROM school.courses;
INSERT INTO school.enrollments
    (enrollment_id, student_id, course_id, enrollment_date, grade)
VALUES
    (1001, 1, 101, '2024-06-01', 90),
    (1002, 1, 102, '2024-06-02', 85),
    (1003, 2, 101, '2024-06-03', 88),
    (1004, 2, 103, '2024-06-04', 92),
    (1005, 3, 102, '2024-06-05', 78),
    (1006, 4, 103, '2024-06-06', 95),
    (1007, 4, 104, '2024-06-07', 89),
    (1008, 5, 104, '2024-06-08', 82);
 SELECT *
FROM school.enrollments;

UPDATE school.enrollments
SET student_id = 3
WHERE enrollment_id = 1008;
SELECT *
FROM school.enrollments
ORDER BY enrollment_id;

INSERT INTO school.students
    (student_id, first_name, last_name, email, city, joined_date)
VALUES
    (6, 'Olivia', 'Martin', 'olivia@gmail.com', 'Austin', '2024-07-15');

UPDATE school.students
SET city = 'Houston'
WHERE student_id = 2;

UPDATE school.courses
SET fee = 550.00
WHERE course_id = 101;

DELETE FROM school.enrollments
WHERE enrollment_id = 1007;

SELECT *
FROM school.students;

SELECT *
FROM school.students;

SELECT first_name, last_name, email
FROM school.students;

SELECT *
FROM school.students
WHERE city = 'Houston';

SELECT *
FROM school.courses
WHERE fee > 500;

SELECT *
FROM school.courses
ORDER BY fee DESC;

SELECT AVG(fee) AS average_course_fee
FROM school.courses;

SELECT
    MIN(fee) AS minimum_course_fee,
    MAX(fee) AS maximum_course_fee
FROM school.courses;

SELECT COUNT(*) AS total_students
FROM school.students;

SELECT
    course_id,
    COUNT(student_id) AS student_count
FROM school.enrollments
GROUP BY course_id;

SELECT
    s.first_name || ' ' || s.last_name AS student_name,
    c.course_name,
    c.instructor,
    e.grade
FROM school.students s
JOIN school.enrollments e
    ON s.student_id = e.student_id
JOIN school.courses c
    ON e.course_id = c.course_id;

SELECT
    s.first_name,
    s.last_name,
    e.grade
FROM school.students s
JOIN school.enrollments e
    ON s.student_id = e.student_id
ORDER BY e.grade DESC
LIMIT 1;

SELECT
    c.course_name,
    AVG(e.grade) AS average_grade
FROM school.courses c
JOIN school.enrollments e
    ON c.course_id = e.course_id
GROUP BY c.course_name;

SELECT
    s.student_id,
    s.first_name,
    s.last_name,
    COUNT(e.course_id) AS course_count
FROM school.students s
JOIN school.enrollments e
    ON s.student_id = e.student_id
GROUP BY
    s.student_id,
    s.first_name,
    s.last_name
HAVING COUNT(e.course_id) > 1;

SELECT
    s.student_id,
    s.first_name,
    s.last_name
FROM school.students s
LEFT JOIN school.enrollments e
    ON s.student_id = e.student_id
WHERE e.enrollment_id IS NULL;

SELECT *
FROM school.courses
ORDER BY fee DESC
LIMIT 1;

