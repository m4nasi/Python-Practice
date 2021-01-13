ans = sum([len(set(entry.replace("\n",""))) for entry in open("day 6.txt").read().split("\n\n")])
print(ans)
p2 = sum(len(set.intersection(*map(set, entry.split()))) for entry in open("day 6.txt").read().split("\n\n"))
print(p2)
