import random

responses = ["It is certain.", "It is decidedly so.", "Without a doubt.", "Yes, definitely.",
             "You may rely on it.", "As I see it, yes.", "Outlook good", "Yes.",
             "Signs point to yes.", "Reply hazy, try again.", "Ask again later.",
             "Cannot predict now.", "Concentrate and ask again.", "Don't count on it.",
             "My reply is no.", "My sources say no.", "Outlook not so good.", "Very doubtful."]

print("Magic 8-Ball | What is your question?")

while True:
    question = input("\n> ")
    if question.lower() == "quit" or question.lower() == "exit":
        break
    print(random.choice(responses))
