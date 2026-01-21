using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

public class MySqlHelper
{
    private readonly string connStr = "server=localhost;user=root;database=decodeanddiscovers;port=3306;password=";

    public void SaveProgress(string playerName, string story, string language, int chapter, int score)
    {
        try
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"INSERT INTO player_progress (player_name, selected_story, selected_language, chapter_number, score)
                                 VALUES (@playerName, @story, @language, @chapter, @score)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@playerName", playerName);
                    cmd.Parameters.AddWithValue("@story", story);
                    cmd.Parameters.AddWithValue("@language", language);
                    cmd.Parameters.AddWithValue("@chapter", chapter);
                    cmd.Parameters.AddWithValue("@score", score);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error saving progress: " + ex.Message);
        }
    }
}
