using System;
using System.Collections.Generic;

namespace Array_and_List
{
    public static class Facebook
    {
        // If no one likes your post, it doesn't display anything.
        // If only one person likes your post, it displays: [Friend's Name] likes your post.
        // If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        public static string CheckLikability(int count, List<string> namesList)
        {
            if ((namesList == null) || (count > namesList.Count)) return " ";
            switch (count)
                {
                    case 1:
                        return namesList[0] + " likes your post.";
                    case 2:
                        return String.Format("{0}, {1} likes your post", namesList[0], namesList[1]);
                    default:
                    {
                        if (count > 2) {
                            return String.Format("{0}, {1} and {2} others like your post.", namesList[0], namesList[1],
                                count - 2);
                        }
                        else return "";
                    }
                }
        }
    }
}