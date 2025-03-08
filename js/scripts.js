const observer = new IntersectionObserver((entries) =>{
  entries.forEach((entry) =>{
      console.log(entry)
      if (entry.isIntersecting) {
          entry.target.classList.add('logoToolsShow');
      } else {
          entry.target.classList.remove('logoToolsShow');
      }
  });
}); 

const hiddenElements = document.querySelectorAll('.logoToolsHiddenLeft, .logoToolsHiddenRight, .logoToolsHiddenDown');
hiddenElements.forEach((el) => observer.observe(el));



