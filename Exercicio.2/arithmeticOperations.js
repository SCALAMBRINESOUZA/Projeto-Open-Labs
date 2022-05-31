const list = [-3, 8, 12, -5, 1, 4, 21, 13, 7]

const media = (list) => {
  let average = 0
  let sum = 0
  for (let i = 0; i < list.length; i += 1) {
    sum += list[i]
    average = sum / list.length
  }
  return average
}

const maiorValor = (list) => {
  let max = 0
  for (li in list) {
    max = Math.max(...list)
  }
  return max
}

const menorValor = (list) => {
  let min = 21
  for (li in list) {
    list[li] < min ? min = list[li] : min
    return min
  }
}
