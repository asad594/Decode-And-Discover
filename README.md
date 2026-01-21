# 🔍 Decode-And-Discover
🎮 An interactive Windows Forms application that blends storytelling and programming quizzes and provides feedbacks through memes based on your score !   You get to choose a genre (Crime, Horror, Funny) and a programming language (C#, Java, Python) — and answer language-specific questions while unraveling a gripping story.

---

## 📚 Features

- ✅ Choose your own story: Crime, Horror, or Funny
- ✅ Learn through quizzes in C#, Java, or Python
- ✅ Score-based progression system
- ✅ Score-based memes feedback
- ✅ Clean OOP design using inheritance, polymorphism, and abstraction
- ✅ MySQL integration to store player progress

---

## 💡 Technologies Used

- C# (Windows Forms)
- Object-Oriented Programming (Inheritance, Polymorphism, Abstraction, Encapsulation)
- XAMPP + MySQL (for saving game progress)
- Visual Studio 2022

---

## 🎮 How to Play

1. Clone this repo.
2. Open the solution in Visual Studio.
3. Build and run the project.
4. Enter your name, pick a story + language, and start exploring!
5. Answer quiz questions to move through chapters.
6. Your score and choices are saved in a MySQL database.

---

## 🗃️ Database Setup (MySQL)

1. Open **XAMPP** and **start MySQL**.
2. Go to `http://localhost/phpmyadmin`
3. Create a new database called: `decode_db`
4. Run this SQL in the SQL tab:

```sql
CREATE TABLE player_progress (
    id INT AUTO_INCREMENT PRIMARY KEY,
    player_name VARCHAR(50),
    selected_story VARCHAR(50),
    selected_language VARCHAR(50),
    chapter_number INT,
    score INT
);
